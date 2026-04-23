---
title: Performance
_description: Benchmark results for JNet — JVM method invocation and callback latency from .NET
---

# JNet: performance

This page reports benchmark results for the core JNet interop primitives: JVM method invocation from .NET and JVM→.NET callback latency.
All benchmarks run on [GitHub Actions](https://github.com/masesgroup/JNet/actions) runners and are repeated automatically on each release across supported .NET and JDK versions.

Results are reported for three JCOBridge versions — 2.6.6, 2.6.7+, and 2.6.9 — and two runtime combinations. See [JCOBridge release notes](https://www.jcobridge.com/release-notes/) for details.

> [!NOTE]
> Benchmarks are run on shared GitHub-hosted runners. Absolute numbers reflect that environment and should be read comparatively rather than as absolute throughput figures for a dedicated host.

---

## Test environment

| Parameter | Combination A | Combination B |
|---|---|---|
| Runner | GitHub Actions (`ubuntu-latest`) | GitHub Actions (`ubuntu-latest`) |
| Iterations per test | 1 000 000 | 1 000 000 |
| .NET version | .NET 8 | .NET 10 |
| JDK version | Temurin 17 | Temurin 25 |

---

## What is measured

### JVM method invocation from .NET

Measures the round-trip latency of calling a JVM method from .NET through JNet, with two resolution strategies and two method signatures.

**Resolution strategies:**
- **Invoke** — the method is identified by .NET-side type matching against input arguments on every call. The JVM descriptor is cached after first resolution, but argument type validation is re-evaluated on the .NET side at each invocation.
- **InvokeWithSignature** (`IWS`) — the method is identified by name and JNI signature string. Argument validation is delegated to the JVM, eliminating the .NET-side type matching cost.

**Method signatures (`feedback`):**
- **`feedback = false`** — method takes no arguments and returns `void`. Measures pure invocation overhead.
- **`feedback = true`** — method takes a `boolean` argument and returns the same `boolean`. Measures the additional cost of argument passing and return value marshalling across the JNI boundary.

Both static and instance method variants are tested.

### Callback: `TestPredicateRoundTrip` (.NET → JVM → .NET)

A .NET-initiated test: .NET triggers a JVM call which immediately fires a callback back into .NET. Provides a controlled start-time marker and measures the full bidirectional round-trip. In real usage the JVM initiates the event — see `TestPredicateSustained` for the realistic reference.

### Callback: `TestPredicateSustained` (JVM → .NET, sustained)

A JVM-initiated test: .NET sends a single start command to JVM, which then fires 1 000 000 callback events toward the CLR autonomously without returning control to .NET. After all events are fired, the JVM returns and .NET measures the total elapsed time. Aside from the single startup call, this measures the pure cost of receiving a sustained stream of JVM-originated events — the scenario matching real-world usage (e.g. Kafka Streams functional interfaces, AWT event listeners).

Both callback tests share two configuration axes (2.6.7+ only):

**`byIndex` — event trigger identification:**
- **`byIndex = false`** — the event is identified on the CLR side by a string key lookup.
- **`byIndex = true`** — the event is identified on the CLR side by a numeric index, without any JVM call. In both cases, JVM object arguments are retrieved as JVM objects after the trigger is received.

**Two-level early-discard filter (`ShallManageEvent`, 2.6.7+):**

JCOBridge 2.6.7+ introduces two overloads of `ShallManageEvent` on the JNet callback base class, forming a two-gate filter applied before full event handling:

**First gate — `bool ShallManageEvent(string eventName)`:** called before any argument data is read from the JVM. The return value:
- **`false`** (`continueFirstCheck = false`) — discard immediately: no data is read, the handler is not invoked.
- **`true`** (`continueFirstCheck = true`) — proceed to the second gate.

**Second gate — `bool ShallManageEvent(string eventName, object data)`:** called after raw argument data is available but before full event processing and handler dispatch. Allows lightweight inspection of the raw data (e.g. a field check) without paying the cost of full conversion. The return value:
- **`false`** (`continueSecondCheck = false`) — discard after raw-data inspection: the registered handler is not invoked.
- **`true`** (`continueSecondCheck = true`) — proceed normally: full argument conversion and handler invocation.

The combination `continueFirstCheck = false, continueSecondCheck = true` is never reached and is not tested.

`ShallManageEventHandler` (`Func<string, bool>`) is the delegate equivalent of the first gate; `ShallManageEventWithDataHandler` (`Func<string, object, bool>`) is the delegate equivalent of the second gate. Default for both gates is `true` (full processing).

---

## JCOBridge 2.6.6

In 2.6.6, `ShallManageEventHandler`, `ShallManageEventWithDataHandler`, and the native `byIndex` trigger mechanism are not yet available.

### Static method invocation

| Resolution | `feedback` | .NET 8 / T17 | .NET 10 / T25 |
|---|---|---|---|
| `Invoke` | `false` | 0.661 µs | 0.602 µs |
| `IWS` | `false` | 0.494 µs | 0.414 µs |
| `Invoke` | `true` | 0.901 µs | 0.803 µs |
| `IWS` | `true` | 0.686 µs | 0.522 µs |

### Instance method invocation

| Resolution | `feedback` | .NET 8 / T17 | .NET 10 / T25 |
|---|---|---|---|
| `Invoke` | `false` | 0.579 µs | 0.490 µs |
| `IWS` | `false` | 0.468 µs | 0.379 µs |
| `Invoke` | `true` | 0.856 µs | 0.764 µs |
| `IWS` | `true` | 0.638 µs | 0.535 µs |

Adding a `boolean` argument and return value (`feedback = true`) adds ~45–55% overhead with `Invoke` and ~35–40% with `IWS`, reflecting JNI argument marshalling cost.

### Callback

| Test | `byIndex` | `readJVM` | .NET 8 / T17 | .NET 10 / T25 |
|---|---|---|---|---|
| `RoundTrip` | `false` | `true` | 6.945 µs | 6.338 µs |
| `Sustained` | `false` | `true` | 6.116 µs | 5.548 µs |

`Sustained` is the realistic reference for JVM-originated callback cost: **~6.1 µs (.NET 8 / T17) and ~5.5 µs (.NET 10 / T25).**

---

## JCOBridge 2.6.7+

JCOBridge 2.6.7+ introduces the two-level `ShallManageEvent` filter and the native `byIndex` trigger mechanism. General interop improvements reduce baseline overhead across all test types.

> [!NOTE]
> `byIndex = true` is still simulated on the JVM side by invoking a dedicated class method rather than the interface `@Override`. The CLR-side numeric index resolution is fully active; a JVM dispatch difference (class method vs interface method) remains. The `byIndex = false` rows use the real interface override and are directly comparable between the two versions.

### Static method invocation

| Resolution | `feedback` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|
| `Invoke` | `false` | 0.517 µs | −22% | 0.480 µs | −20% |
| `IWS` | `false` | 0.356 µs | −28% | 0.335 µs | −19% |
| `Invoke` | `true` | 0.609 µs | −32% | 0.575 µs | −28% |
| `IWS` | `true` | 0.435 µs | −37% | 0.419 µs | −20% |

### Instance method invocation

| Resolution | `feedback` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|
| `Invoke` | `false` | 0.349 µs | −40% | 0.301 µs | −39% |
| `IWS` | `false` | 0.295 µs | −37% | 0.274 µs | −28% |
| `Invoke` | `true` | 0.552 µs | −36% | 0.511 µs | −33% |
| `IWS` | `true` | 0.448 µs | −30% | 0.452 µs | −15% |

### Callback: `TestPredicateRoundTrip`

| `byIndex` | `continueFirstCheck` | `continueSecondCheck` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|---|
| `false` | `false` | `false` | 1.106 µs | — | 1.040 µs | — |
| `true` ¹ | `false` | `false` | 0.452 µs | — | 0.435 µs | — |
| `false` | `true` | `false` | 1.126 µs | — | 1.074 µs | — |
| `true` ¹ | `true` | `false` | 0.502 µs | — | 0.456 µs | — |
| `false` | `true` | `true` | 5.794 µs | −16% | 5.318 µs | −16% |
| `true` ¹ | `true` | `true` | 5.023 µs | −28% | 4.628 µs | −27% |

¹ `byIndex = true` simulated on the JVM side — see note above.

### Callback: `TestPredicateSustained`

| `byIndex` | `continueFirstCheck` | `continueSecondCheck` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|---|
| `false` | `false` | `false` | 0.601 µs | −90% | 0.468 µs | −92% |
| `true` ¹ | `false` | `false` | **0.045 µs** | — | **0.041 µs** | — |
| `false` | `true` | `false` | 0.625 µs | −90% | 0.493 µs | −91% |
| `true` ¹ | `true` | `false` | **0.074 µs** | — | **0.067 µs** | — |
| `false` | `true` | `true` | 5.098 µs | −17% | 4.725 µs | −15% |
| `true` ¹ | `true` | `true` | 4.467 µs | −27% | 4.141 µs | −25% |

¹ `byIndex = true` simulated on the JVM side — see note above.

The **realistic JVM-originated callback baseline** (full processing, `byIndex = false`) is **5.1 µs (.NET 8 / T17)** and **4.7 µs (.NET 10 / T25)**.

---

## JCOBridge 2.6.9

JCOBridge 2.6.9 delivers further reductions across all test types, with the most significant gains on the sustained full-processing callback path.

> [!NOTE]
> `byIndex = true` is still simulated on the JVM side — see note in the 2.6.7+ section above.

### Static method invocation

| Resolution | `feedback` | .NET 8 / T17 | vs 2.6.7+ | .NET 10 / T25 | vs 2.6.7+ |
|---|---|---|---|---|---|
| `Invoke` | `false` | 0.530 µs | ~0% | 0.521 µs | +9% |
| `IWS` | `false` | 0.337 µs | −5% | 0.334 µs | ~0% |
| `Invoke` | `true` | 0.555 µs | **−9%** | 0.512 µs | **−11%** |
| `IWS` | `true` | 0.400 µs | **−8%** | 0.390 µs | **−7%** |

### Instance method invocation

| Resolution | `feedback` | .NET 8 / T17 | vs 2.6.7+ | .NET 10 / T25 | vs 2.6.7+ |
|---|---|---|---|---|---|
| `Invoke` | `false` | 0.332 µs | −5% | 0.305 µs | +1% |
| `IWS` | `false` | 0.278 µs | −6% | 0.272 µs | ~0% |
| `Invoke` | `true` | 0.549 µs | ~0% | 0.477 µs | **−7%** |
| `IWS` | `true` | 0.435 µs | −3% | 0.388 µs | **−14%** |

### Callback: `TestPredicateRoundTrip`

| `byIndex` | `continueFirstCheck` | `continueSecondCheck` | .NET 8 / T17 | vs 2.6.7+ | .NET 10 / T25 | vs 2.6.7+ |
|---|---|---|---|---|---|---|
| `false` | `false` | `false` | 1.117 µs | +1% | 1.023 µs | −2% |
| `true` ¹ | `false` | `false` | 0.461 µs | +2% | 0.391 µs | −10% |
| `false` | `true` | `false` | 1.141 µs | +1% | 0.994 µs | −7% |
| `true` ¹ | `true` | `false` | 0.495 µs | −1% | 0.407 µs | −11% |
| `false` | `true` | `true` | 4.983 µs | **−14%** | 4.573 µs | **−14%** |
| `true` ¹ | `true` | `true` | 4.197 µs | **−16%** | 3.846 µs | **−17%** |

¹ `byIndex = true` simulated on the JVM side — see note above.

### Callback: `TestPredicateSustained`

| `byIndex` | `continueFirstCheck` | `continueSecondCheck` | .NET 8 / T17 | vs 2.6.7+ | .NET 10 / T25 | vs 2.6.7+ |
|---|---|---|---|---|---|---|
| `false` | `false` | `false` | 0.553 µs | −8% | 0.470 µs | ~0% |
| `true` ¹ | `false` | `false` | **0.051 µs** | +13% | **0.041 µs** | ~0% |
| `false` | `true` | `false` | 0.567 µs | −9% | 0.488 µs | −1% |
| `true` ¹ | `true` | `false` | **0.066 µs** | −11% | **0.057 µs** | **−15%** |
| `false` | `true` | `true` | 4.237 µs | **−17%** | 3.990 µs | **−16%** |
| `true` ¹ | `true` | `true` | 3.606 µs | **−19%** | 3.327 µs | **−20%** |

¹ `byIndex = true` simulated on the JVM side — see note above.

The **realistic JVM-originated callback baseline** (full processing, `byIndex = false`) improves to **4.2 µs (.NET 8 / T17)** and **4.0 µs (.NET 10 / T25)** — a **−17% / −16%** reduction over 2.6.7+ and **−31% / −28%** over 2.6.6.

The three distinct operating points are:

**First gate only (`continueFirstCheck = false`)** — event discarded before any data is read:
- `byIndex = false`: ~0.55 µs / ~0.47 µs.
- `byIndex = true`: **~51 ns (.NET 8) / ~41 ns (.NET 10)**.

**Second gate (`continueFirstCheck = true, continueSecondCheck = false`)** — raw data available for inspection, handler not invoked:
- `byIndex = false`: ~0.57 µs / ~0.49 µs.
- `byIndex = true`: **~66 ns (.NET 8) / ~57 ns (.NET 10)**.

**Full processing (`continueFirstCheck = true, continueSecondCheck = true`)**: ~4.2 µs / ~4.0 µs as above.

---

## Summary

| Test | .NET 8 / T17 | | | .NET 10 / T25 | | |
|---|---|---|---|---|---|---|
| | 2.6.6 | 2.6.7+ | 2.6.9 | 2.6.6 | 2.6.7+ | 2.6.9 |
| Static `Invoke` fb=false | 0.661 µs | 0.517 µs (−22%) | 0.530 µs | 0.602 µs | 0.480 µs (−20%) | 0.521 µs |
| Static `IWS` fb=false | 0.494 µs | 0.356 µs (−28%) | 0.337 µs (−32%) | 0.414 µs | 0.335 µs (−19%) | 0.334 µs (−19%) |
| Static `Invoke` fb=true | 0.901 µs | 0.609 µs (−32%) | 0.555 µs (−38%) | 0.803 µs | 0.575 µs (−28%) | 0.512 µs (−36%) |
| Static `IWS` fb=true | 0.686 µs | 0.435 µs (−37%) | 0.400 µs (−42%) | 0.522 µs | 0.419 µs (−20%) | 0.390 µs (−25%) |
| Instance `Invoke` fb=false | 0.579 µs | 0.349 µs (−40%) | 0.332 µs (−43%) | 0.490 µs | 0.301 µs (−39%) | 0.305 µs (−38%) |
| Instance `IWS` fb=false | 0.468 µs | 0.295 µs (−37%) | 0.278 µs (−41%) | 0.379 µs | 0.274 µs (−28%) | 0.272 µs (−28%) |
| Instance `Invoke` fb=true | 0.856 µs | 0.552 µs (−36%) | 0.549 µs (−36%) | 0.764 µs | 0.511 µs (−33%) | 0.477 µs (−38%) |
| Instance `IWS` fb=true | 0.638 µs | 0.448 µs (−30%) | 0.435 µs (−32%) | 0.535 µs | 0.452 µs (−15%) | 0.388 µs (−27%) |
| Sustained: full, `byIndex=false` | 6.116 µs | 5.098 µs (−17%) | 4.237 µs (−31%) | 5.548 µs | 4.725 µs (−15%) | 3.990 µs (−28%) |
| Sustained: full, `byIndex=true` ¹ | — | 4.467 µs | 3.606 µs (−19%) | — | 4.141 µs | 3.327 µs (−20%) |
| Sustained: 1st gate, `byIndex=false` | — | 0.601 µs | 0.553 µs | — | 0.468 µs | 0.470 µs |
| Sustained: 1st gate, `byIndex=true` ¹ | — | **0.045 µs** | **0.051 µs** | — | **0.041 µs** | **0.041 µs** |
| Sustained: 2nd gate, `byIndex=false` | — | 0.625 µs | 0.567 µs | — | 0.493 µs | 0.488 µs |
| Sustained: 2nd gate, `byIndex=true` ¹ | — | **0.074 µs** | **0.066 µs** | — | **0.067 µs** | **0.057 µs** |

¹ `byIndex = true` simulated on the JVM side in 2.6.7+ and 2.6.9 — see notes above. No 2.6.6 baseline available. All percentages vs 2.6.6.

### Comparison with raw JNI overhead

The ~41–51 ns figure for `byIndex = true`, first-gate discard (Sustained) is worth contextualizing against published raw JNI benchmarks on dedicated hardware. Independent JMH benchmarks measure an empty JNI call at ~57 ns via JavaCPP and ~22 ns on a modern laptop for a minimal no-op native method ([java-native-benchmark](https://github.com/zakgof/java-native-benchmark), [Komanov 2022](https://dkomanov.medium.com/java-native-access-performance-cf4ce0d68ddb)).

JNet's first-gate discard path involves a JVM→CLR crossing, the numeric index lookup, and the `ShallManageEvent` decision — all on shared CI infrastructure. Staying in the 41–51 ns range per event places JNet within the range of raw JNI call overhead measured on dedicated bare-metal hardware, despite the additional CLR interop layer.

---

## Guidance

- **Prefer `InvokeWithSignature`** (`IWS`) over `Invoke` in hot paths — it avoids .NET-side type matching on every call and consistently delivers 20–40% lower latency when arguments are involved.
- **The realistic JVM-originated callback reference** is `Sustained`, full processing, `byIndex = false`: **~4.2 µs (.NET 8 / T17) and ~4.0 µs (.NET 10 / T25)** in 2.6.9. With `byIndex = true` this drops to ~3.6 µs and ~3.3 µs.
- **Use the two-level `ShallManageEvent` filter** for high-event-rate sources where only a subset of events require full processing:
  - First gate (`ShallManageEventHandler`) — discard by event name alone, before any data read: ~51 ns (.NET 8) / ~41 ns (.NET 10) with `byIndex = true`.
  - Second gate (`ShallManageEventWithDataHandler`) — inspect raw data before deciding: ~66 ns (.NET 8) / ~57 ns (.NET 10) with `byIndex = true`. Use this when a lightweight field check on the raw payload is needed to decide whether to invoke the handler.
- **Newer runtimes help**: .NET 10 / Temurin 25 consistently matches or outperforms .NET 8 / Temurin 17, with the largest gains visible on the full-processing callback path.
- The `byIndex = true` mechanism will deliver its full benefit on the full-processing path once the JVM-side simulation is replaced with real interface dispatch.
- If your application runs callbacks at sustained high frequency, consider the [JCOBridge HPA edition](https://www.jcobridge.com) — it addresses GC-boundary instability under sustained JVM↔CLR call pressure, which is the primary reliability concern at high call rates.
