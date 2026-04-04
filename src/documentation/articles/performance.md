---
title: Performance
_description: Benchmark results for JNet — JVM method invocation and callback round-trip latency from .NET
---

# JNet: performance

This page reports benchmark results for the core JNet interop primitives: JVM method invocation from .NET and .NET↔JVM callback latency in both directions.
All benchmarks run on [GitHub Actions](https://github.com/masesgroup/JNet/actions) runners and are repeated automatically on each release across supported .NET and JDK versions.

Results are reported for two JCOBridge versions — 2.6.6 and 2.6.7-beta6 — and two runtime combinations. See [JCOBridge release notes](https://www.jcobridge.com/release-notes/) for details.

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
- **InvokeWithSignature** — the method is identified by name and JNI signature string. Argument validation is delegated to the JVM, eliminating the .NET-side type matching cost.

**Method signatures (`feedback`):**
- **`feedback = false`** — method takes no arguments and returns `void`. Measures pure invocation overhead.
- **`feedback = true`** — method takes a `boolean` argument and returns the same `boolean`. Measures the additional cost of argument passing and return value marshalling across the JNI boundary.

Both static and instance method variants are tested.

### Callback: `TestPredicateRoundTrip` (.NET → JVM → .NET)

A .NET-initiated test: .NET triggers a JVM call which immediately fires a callback back into .NET, where it is handled and the result is returned to JVM. This provides a controlled start-time marker and measures the full bidirectional round-trip latency. In real usage, the JVM initiates the event — see `TestPredicateSustained` below.

### Callback: `TestPredicateSustained` (JVM → .NET, sustained)

A JVM-initiated test: .NET sends a single start command to JVM, which then fires 1 000 000 callback events toward the CLR autonomously without returning control to .NET. After all events are fired, the JVM returns and .NET measures the total elapsed time. Aside from the single startup call, this test measures the pure cost of receiving a sustained stream of JVM-originated callbacks — the scenario that matches real-world usage (e.g. Kafka Streams functional interfaces, AWT event listeners).

Both callback tests share two configuration axes (2.6.7-beta6 only):

**`byIndex` — event trigger identification:**
- **`byIndex = false`** — the event is identified by a string key lookup on the CLR side.
- **`byIndex = true`** — the event is identified by a numeric index resolved on the CLR side without any JVM call. In both cases, JVM object arguments are retrieved as JVM objects after the trigger is received.

**`readJVM` — early-discard filter (`ShallManageEventHandler`, 2.6.7+):**

JCOBridge 2.6.7 introduces `ShallManageEventHandler` (`Func<string, bool>`) and the equivalent virtual method `bool ShallManageEvent(string)` on the JNet callback base class. Before any JVM argument data is read, JNet calls this handler with the event name. The user can:
- **Return `true`** (default) — proceed normally: argument data is read from JVM and the callback handler is invoked.
- **Return `false`** — discard the event immediately: no argument data is read and the callback handler is not invoked. The user can still execute logic inside `ShallManageEvent` before returning `false`.

For `byIndex = true`, the event name string passed to `ShallManageEvent` is resolved on the CLR side — no JVM round-trip is needed. For `byIndex = false`, it is resolved via string key lookup.

In the test, `readJVM = true` simulates a handler that always returns `true` (normal flow); `readJVM = false` simulates one that always returns `false` (always discard). Default is `true`.

---

## JCOBridge 2.6.6

In 2.6.6, `ShallManageEventHandler` and the native `byIndex` trigger mechanism are not yet available.

### Static method invocation

| Resolution | `feedback` | .NET 8 / T17 | .NET 10 / T25 |
|---|---|---|---|
| `Invoke` | `false` | 0.661 µs | 0.602 µs |
| `InvokeWithSignature` | `false` | 0.494 µs | 0.414 µs |
| `Invoke` | `true` | 0.901 µs | 0.803 µs |
| `InvokeWithSignature` | `true` | 0.686 µs | 0.522 µs |

### Instance method invocation

| Resolution | `feedback` | .NET 8 / T17 | .NET 10 / T25 |
|---|---|---|---|
| `Invoke` | `false` | 0.579 µs | 0.490 µs |
| `InvokeWithSignature` | `false` | 0.468 µs | 0.379 µs |
| `Invoke` | `true` | 0.856 µs | 0.764 µs |
| `InvokeWithSignature` | `true` | 0.638 µs | 0.535 µs |

Adding a `boolean` argument and return value (`feedback = true`) adds ~45–55% overhead with `Invoke` and ~35–40% with `InvokeWithSignature`, reflecting the JNI argument marshalling cost.

### Callback

| Test | `byIndex` | `readJVM` | .NET 8 / T17 | .NET 10 / T25 |
|---|---|---|---|---|
| `RoundTrip` | `false` | `true` | 6.945 µs | 6.338 µs |
| `Sustained` | `false` | `true` | 6.116 µs | 5.548 µs |

The `Sustained` test — pure JVM-originated events — is ~12% faster than the `RoundTrip` total, confirming that the .NET→JVM startup trigger in `RoundTrip` adds measurable overhead. **The `Sustained` result is the realistic reference for JVM-originated callback cost: ~6.1 µs (.NET 8 / T17) and ~5.5 µs (.NET 10 / T25).**

---

## JCOBridge 2.6.7-beta6

JCOBridge 2.6.7 introduces `ShallManageEventHandler` and the native `byIndex` trigger mechanism. General interop improvements reduce baseline overhead across all test types.

> [!NOTE]
> `byIndex = true` is still simulated on the JVM side by invoking a dedicated class method rather than the interface `@Override`. The CLR-side numeric index resolution is fully active; the JVM dispatch difference (class method vs interface method) remains. The `byIndex = false` rows use the real interface override and are directly comparable between the two versions.

### Static method invocation

| Resolution | `feedback` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|
| `Invoke` | `false` | 0.498 µs | −25% | 0.471 µs | −22% |
| `InvokeWithSignature` | `false` | 0.403 µs | −18% | 0.345 µs | −17% |
| `Invoke` | `true` | 0.608 µs | −33% | 0.562 µs | −30% |
| `InvokeWithSignature` | `true` | 0.462 µs | −33% | 0.437 µs | −16% |

### Instance method invocation

| Resolution | `feedback` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|
| `Invoke` | `false` | 0.359 µs | −38% | 0.315 µs | −36% |
| `InvokeWithSignature` | `false` | 0.316 µs | −32% | 0.288 µs | −24% |
| `Invoke` | `true` | 0.553 µs | −35% | 0.539 µs | −29% |
| `InvokeWithSignature` | `true` | 0.456 µs | −29% | 0.448 µs | −16% |

The `feedback = true` overhead over `feedback = false` narrows compared to 2.6.6: `Invoke` pays ~50% extra (down from ~45–55%), `InvokeWithSignature` ~44% (down from ~35–40%) — the interop layer improvements benefit argument-carrying calls proportionally.

### Callback: `TestPredicateRoundTrip`

| `byIndex` | `readJVM` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|
| `false` | `false` | 1.117 µs | — | 1.037 µs | — |
| `true` ¹ | `false` | 0.453 µs | — | 0.430 µs | — |
| `false` | `true` | 6.033 µs | −13% | 5.712 µs | −10% |
| `true` ¹ | `true` | 5.399 µs | −22% | 4.987 µs | −21% |

¹ `byIndex = true` simulated on the JVM side — see note above.

### Callback: `TestPredicateSustained`

| `byIndex` | `readJVM` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|
| `false` | `false` | 5.415 µs | −12% | 5.041 µs | −9% |
| `true` ¹ | `false` | 4.780 µs | −22% | 4.494 µs | −19% |
| `false` | `true` | 5.419 µs | −11% | 5.052 µs | −9% |
| `true` ¹ | `true` | 4.757 µs | −22% | 4.493 µs | −19% |

¹ `byIndex = true` simulated on the JVM side — see note above.

**Notable:** in the `Sustained` test, `readJVM = false` and `readJVM = true` produce virtually identical results for the same `byIndex` setting. This reveals that in a sustained JVM-originated event stream, the JVM-side event generation cost dominates — whether or not the CLR reads argument data has negligible impact on the per-event time. The `ShallManageEventHandler` early-discard filter is most effective when events are sporadic or when the JVM fires them at a lower rate, not when the JVM itself is the bottleneck.

The **realistic JVM-originated callback baseline** in 2.6.7-beta6 is **~5.4 µs** (`byIndex = false`, .NET 8 / T17) and **~5.0 µs** (.NET 10 / T25) — improvements of ~11% and ~9% over 2.6.6. With `byIndex = true`, this drops to **~4.8 µs** and **~4.5 µs** (~22% and ~19% better than 2.6.6).

---

## Summary

| Test | .NET 8 / T17 2.6.6 | .NET 8 / T17 2.6.7-β6 | Δ | .NET 10 / T25 2.6.6 | .NET 10 / T25 2.6.7-β6 | Δ |
|---|---|---|---|---|---|---|
| Static `Invoke` fb=false | 0.661 µs | 0.498 µs | −25% | 0.602 µs | 0.471 µs | −22% |
| Static `IWS` fb=false | 0.494 µs | 0.403 µs | −18% | 0.414 µs | 0.345 µs | −17% |
| Static `Invoke` fb=true | 0.901 µs | 0.608 µs | −33% | 0.803 µs | 0.562 µs | −30% |
| Static `IWS` fb=true | 0.686 µs | 0.462 µs | −33% | 0.522 µs | 0.437 µs | −16% |
| Instance `Invoke` fb=false | 0.579 µs | 0.359 µs | −38% | 0.490 µs | 0.315 µs | −36% |
| Instance `IWS` fb=false | 0.468 µs | 0.316 µs | −32% | 0.379 µs | 0.288 µs | −24% |
| Instance `Invoke` fb=true | 0.856 µs | 0.553 µs | −35% | 0.764 µs | 0.539 µs | −29% |
| Instance `IWS` fb=true | 0.638 µs | 0.456 µs | −29% | 0.535 µs | 0.448 µs | −16% |
| Sustained `byIndex=false` | 6.116 µs | 5.419 µs | −11% | 5.548 µs | 5.052 µs | −9% |
| Sustained `byIndex=true` ¹ | — | 4.757 µs | — | — | 4.493 µs | — |

¹ `byIndex = true` simulated on the JVM side in 2.6.7-beta6 — see notes above. No baseline in 2.6.6.

---

## Guidance

- **Prefer `InvokeWithSignature`** over `Invoke` in hot paths — it avoids .NET-side type matching on every call. With argument-carrying methods (`feedback = true`), `InvokeWithSignature` is consistently 20–35% faster than `Invoke`.
- **The realistic JVM-originated callback reference** is `TestPredicateSustained`: ~5.4 µs (`byIndex = false`, .NET 8 / T17) and ~5.0 µs (.NET 10 / T25) in 2.6.7-beta6. The `byIndex = true` trigger reduces this to ~4.8 µs and ~4.5 µs.
- **`ShallManageEventHandler`** (`readJVM = false`) has negligible impact when the JVM fires events at its own maximum rate — the JVM-side event generation cost dominates. The filter is most valuable in mixed-load scenarios where only a subset of event types have registered handlers, eliminating the CLR-side data read cost for discarded events.
- **Newer runtimes help**: .NET 10 / Temurin 25 is consistently 5–10% faster than .NET 8 / Temurin 17 across all test types.
- If your application runs callbacks at sustained high frequency, consider the [JCOBridge HPA edition](https://www.jcobridge.com) — it addresses GC-boundary instability under sustained JVM↔CLR call pressure, which is the primary reliability concern at high call rates.
