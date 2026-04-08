---
title: Performance
_description: Benchmark results for JNet — JVM method invocation and callback latency from .NET
---

# JNet: performance

This page reports benchmark results for the core JNet interop primitives: JVM method invocation from .NET and JVM→.NET callback latency.
All benchmarks run on [GitHub Actions](https://github.com/masesgroup/JNet/actions) runners and are repeated automatically on each release across supported .NET and JDK versions.

Results are reported for two JCOBridge versions — 2.6.6 and 2.6.7-rc — and two runtime combinations. See [JCOBridge release notes](https://www.jcobridge.com/release-notes/) for details.

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

Both callback tests share two configuration axes (2.6.7-beta6 only):

**`byIndex` — event trigger identification:**
- **`byIndex = false`** — the event is identified on the CLR side by a string key lookup.
- **`byIndex = true`** — the event is identified on the CLR side by a numeric index, without any JVM call. In both cases, JVM object arguments are retrieved as JVM objects after the trigger is received.

**Two-level early-discard filter (`ShallManageEvent`, 2.6.7+):**

JCOBridge 2.6.7 introduces two overloads of `ShallManageEvent` on the JNet callback base class, forming a two-gate filter applied before full event handling:

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

## JCOBridge 2.6.7-rc

JCOBridge 2.6.7 introduces the two-level `ShallManageEvent` filter and the native `byIndex` trigger mechanism. General interop improvements reduce baseline overhead across all test types.

> [!NOTE]
> `byIndex = true` is still simulated on the JVM side by invoking a dedicated class method rather than the interface `@Override`. The CLR-side numeric index resolution is fully active; a JVM dispatch difference (class method vs interface method) remains. The `byIndex = false` rows use the real interface override and are directly comparable between the two versions.

### Static method invocation

| Resolution | `feedback` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|
| `Invoke` | `false` | 0.513 µs | −22% | 0.488 µs | −19% |
| `IWS` | `false` | 0.355 µs | −28% | 0.341 µs | −18% |
| `Invoke` | `true` | 0.555 µs | −38% | 0.573 µs | −29% |
| `IWS` | `true` | 0.426 µs | −38% | 0.492 µs | −6% |

### Instance method invocation

| Resolution | `feedback` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|
| `Invoke` | `false` | 0.336 µs | −42% | 0.315 µs | −36% |
| `IWS` | `false` | 0.285 µs | −39% | 0.281 µs | −26% |
| `Invoke` | `true` | 0.501 µs | −41% | 0.568 µs | −26% |
| `IWS` | `true` | 0.418 µs | −34% | 0.484 µs | −9% |

### Callback: `TestPredicateRoundTrip`

| `byIndex` | `continueFirstCheck` | `continueSecondCheck` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|---|
| `false` | `false` | `false` | 1.174 µs | — | 1.085 µs | — |
| `true` ¹ | `false` | `false` | 0.421 µs | — | 0.459 µs | — |
| `false` | `true` | `false` | 1.209 µs | — | 1.076 µs | — |
| `true` ¹ | `true` | `false` | 0.470 µs | — | 0.494 µs | — |
| `false` | `true` | `true` | 5.870 µs | −15% | 6.235 µs | −2% |
| `true` ¹ | `true` | `true` | 5.087 µs | −27% | 5.498 µs | −13% |

¹ `byIndex = true` simulated on the JVM side — see note above.

### Callback: `TestPredicateSustained`

| `byIndex` | `continueFirstCheck` | `continueSecondCheck` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|---|
| `false` | `false` | `false` | 0.575 µs | −91% | 0.535 µs | −90% |
| `true` ¹ | `false` | `false` | **0.048 µs** | — | **0.047 µs** | — |
| `false` | `true` | `false` | 0.602 µs | −90% | 0.622 µs | −89% |
| `true` ¹ | `true` | `false` | **0.073 µs** | — | **0.072 µs** | — |
| `false` | `true` | `true` | 5.167 µs | −16% | 5.548 µs | 0% |
| `true` ¹ | `true` | `true` | 4.538 µs | −26% | 4.950 µs | −11% |

¹ `byIndex = true` simulated on the JVM side — see note above.

The **realistic JVM-originated callback baseline** (full processing, `byIndex = false`) is **5.2 µs (.NET 8 / T17)** and **5.5 µs (.NET 10 / T25)**.

The two-level filter reveals three distinct operating points:

**First gate only (`continueFirstCheck = false`)** — event discarded before any data is read:
- `byIndex = false`: ~0.6 µs — string key lookup dominates.
- `byIndex = true`: **~48 ns (.NET 8) / ~47 ns (.NET 10)** — ~21 M events/sec, within the range of raw JNI overhead on bare-metal hardware.

**Second gate (`continueFirstCheck = true, continueSecondCheck = false`)** — event passes first gate, raw data available for inspection, handler not invoked:
- `byIndex = false`: ~0.6 µs — similar to first-gate-only; the raw data read adds negligible overhead at this scale.
- `byIndex = true`: **~73 ns (.NET 8) / ~72 ns (.NET 10)** — the modest increase over first-gate-only reflects the raw data availability cost; still ~14 M events/sec.

**Full processing (`continueFirstCheck = true, continueSecondCheck = true`)**: ~5.2 µs / ~5.5 µs as above.

---

## Summary

| Test | .NET 8 / T17 | | .NET 10 / T25 | |
|---|---|---|---|---|
| | 2.6.6 | 2.6.7-rc | 2.6.6 | 2.6.7-rc |
| Static `Invoke` fb=false | 0.661 µs | 0.513 µs (−22%) | 0.602 µs | 0.488 µs (−19%) |
| Static `IWS` fb=false | 0.494 µs | 0.355 µs (−28%) | 0.414 µs | 0.341 µs (−18%) |
| Static `Invoke` fb=true | 0.901 µs | 0.555 µs (−38%) | 0.803 µs | 0.573 µs (−29%) |
| Static `IWS` fb=true | 0.686 µs | 0.426 µs (−38%) | 0.522 µs | 0.492 µs (−6%) |
| Instance `Invoke` fb=false | 0.579 µs | 0.336 µs (−42%) | 0.490 µs | 0.315 µs (−36%) |
| Instance `IWS` fb=false | 0.468 µs | 0.285 µs (−39%) | 0.379 µs | 0.281 µs (−26%) |
| Instance `Invoke` fb=true | 0.856 µs | 0.501 µs (−41%) | 0.764 µs | 0.568 µs (−26%) |
| Instance `IWS` fb=true | 0.638 µs | 0.418 µs (−34%) | 0.535 µs | 0.484 µs (−9%) |
| Sustained: full processing, `byIndex=false` | 6.116 µs | 5.167 µs (−16%) | 5.548 µs | 5.548 µs (0%) |
| Sustained: full processing, `byIndex=true` ¹ | — | 4.538 µs | — | 4.950 µs |
| Sustained: first gate discard, `byIndex=false` | — | 0.575 µs | — | 0.535 µs |
| Sustained: first gate discard, `byIndex=true` ¹ | — | **0.048 µs** | — | **0.047 µs** |
| Sustained: second gate discard, `byIndex=false` | — | 0.602 µs | — | 0.622 µs |
| Sustained: second gate discard, `byIndex=true` ¹ | — | **0.073 µs** | — | **0.072 µs** |

¹ `byIndex = true` simulated on the JVM side in 2.6.7-rc — see notes above. No 2.6.6 baseline available.

### Comparison with raw JNI overhead

The 47–48 ns figure for `byIndex = true`, first-gate discard (Sustained) is worth contextualizing against published raw JNI benchmarks on dedicated hardware. Independent JMH benchmarks measure an empty JNI call at ~57 ns via JavaCPP and ~22 ns on a modern laptop for a minimal no-op native method ([java-native-benchmark](https://github.com/zakgof/java-native-benchmark), [Komanov 2022](https://dkomanov.medium.com/java-native-access-performance-cf4ce0d68ddb)).

JNet's first-gate discard path involves a JVM→CLR crossing, the numeric index lookup, and the `ShallManageEvent` decision — all on shared CI infrastructure. Reaching ~48 ns per event places JNet within the range of raw JNI call overhead measured on dedicated bare-metal hardware, despite the additional CLR interop layer.

---

## Guidance

- **Prefer `InvokeWithSignature`** (`IWS`) over `Invoke` in hot paths — it avoids .NET-side type matching on every call and consistently delivers 20–40% lower latency when arguments are involved.
- **The realistic JVM-originated callback reference** is `Sustained`, full processing, `byIndex = false`: ~5.2 µs (.NET 8 / T17) and ~5.5 µs (.NET 10 / T25) in 2.6.7-rc. With `byIndex = true` this drops to ~4.5 µs and ~5.0 µs.
- **Use the two-level `ShallManageEvent` filter** for high-event-rate sources where only a subset of events require full processing:
  - First gate (`ShallManageEvent(string)`) — discard by event name alone, before any data read: ~48 ns with `byIndex = true`.
  - Second gate (`ShallManageEvent(string, object)`) — inspect raw data before deciding: ~73 ns with `byIndex = true`. Use this when a lightweight field check on the raw payload is needed to decide whether to invoke the handler.
- **Newer runtimes help**: .NET 10 / Temurin 25 is consistently 5–10% faster than .NET 8 / Temurin 17 across most test types.
- The `byIndex = true` mechanism will deliver its full benefit on the full-processing path once the JVM-side simulation is replaced with real interface dispatch.
- If your application runs callbacks at sustained high frequency, consider the [JCOBridge HPA edition](https://www.jcobridge.com) — it addresses GC-boundary instability under sustained JVM↔CLR call pressure, which is the primary reliability concern at high call rates.
