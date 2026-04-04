---
title: Performance
_description: Benchmark results for JNet — JVM method invocation and callback latency from .NET
---

# JNet: performance

This page reports benchmark results for the core JNet interop primitives: JVM method invocation from .NET and JVM→.NET callback latency.
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

**`readJVM` — early-discard filter (`ShallManageEventHandler`, 2.6.7+):**

JCOBridge 2.6.7 introduces `ShallManageEventHandler` (`Func<string, bool>`) and the equivalent virtual method `bool ShallManageEvent(string)` on the JNet callback base class. Before any JVM argument data is read, JNet calls this handler with the event name. The user can:
- **Return `true`** (default) — proceed normally: argument data is read from JVM and the callback handler is invoked.
- **Return `false`** — discard the event immediately: no argument data is read, no callback invoked. Logic can still run inside `ShallManageEvent` before returning `false`.

For `byIndex = true`, the event name string passed to `ShallManageEvent` is resolved on the CLR side with no JVM round-trip. For `byIndex = false`, it is resolved via string key lookup.

In the test, `readJVM = true` simulates a handler always returning `true` (normal flow); `readJVM = false` simulates one always returning `false` (always discard). Default is `true`.

---

## JCOBridge 2.6.6

In 2.6.6, `ShallManageEventHandler` and the native `byIndex` trigger mechanism are not yet available.

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

## JCOBridge 2.6.7-beta6

JCOBridge 2.6.7 introduces `ShallManageEventHandler` and the native `byIndex` trigger mechanism. General interop improvements reduce baseline overhead across all test types.

> [!NOTE]
> `byIndex = true` is still simulated on the JVM side by invoking a dedicated class method rather than the interface `@Override`. The CLR-side numeric index resolution is fully active; a JVM dispatch difference (class method vs interface method) remains. The `byIndex = false` rows use the real interface override and are directly comparable between the two versions.

### Static method invocation

| Resolution | `feedback` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|
| `Invoke` | `false` | 0.509 µs | −23% | 0.463 µs | −23% |
| `IWS` | `false` | 0.354 µs | −28% | 0.340 µs | −18% |
| `Invoke` | `true` | 0.644 µs | −29% | 0.562 µs | −30% |
| `IWS` | `true` | 0.450 µs | −34% | 0.470 µs | −10% |

### Instance method invocation

| Resolution | `feedback` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|
| `Invoke` | `false` | 0.372 µs | −36% | 0.315 µs | −36% |
| `IWS` | `false` | 0.321 µs | −31% | 0.275 µs | −27% |
| `Invoke` | `true` | 0.571 µs | −33% | 0.529 µs | −31% |
| `IWS` | `true` | 0.458 µs | −28% | 0.500 µs | −6% |

### Callback: `TestPredicateRoundTrip`

| `byIndex` | `readJVM` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|
| `false` | `false` | 1.169 µs | — | 1.045 µs | — |
| `true` ¹ | `false` | 0.478 µs | — | 0.445 µs | — |
| `false` | `true` | 5.851 µs | −16% | 5.673 µs | −10% |
| `true` ¹ | `true` | 5.128 µs | −26% | 4.958 µs | −22% |

¹ `byIndex = true` simulated on the JVM side — see note above.

### Callback: `TestPredicateSustained`

| `byIndex` | `readJVM` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|
| `false` | `false` | 0.605 µs | −90% | 0.498 µs | −91% |
| `true` ¹ | `false` | **0.047 µs** | — | **0.040 µs** | — |
| `false` | `true` | 5.195 µs | −15% | 5.043 µs | −9% |
| `true` ¹ | `true` | 4.557 µs | −26% | 4.295 µs | −23% |

¹ `byIndex = true` simulated on the JVM side — see note above.

The **realistic JVM-originated callback baseline** (`byIndex = false`, `readJVM = true`) is **5.2 µs (.NET 8 / T17)** and **5.0 µs (.NET 10 / T25)** — improvements of 15% and 9% over 2.6.6. With `byIndex = true`, this drops further to **4.6 µs and 4.3 µs** (~25% better than 2.6.6).

The `ShallManageEventHandler` early-discard path (`readJVM = false`) reveals a dramatic split:

- `byIndex = false`: 0.6 µs / 0.5 µs — the string key lookup still dominates even without data reading.
- **`byIndex = true`: 47 ns (.NET 8 / T17) and 40 ns (.NET 10 / T25)** — ~21 M and ~25 M discarded events/sec. With no string lookup and no data read, the CLR entry overhead is reduced to its irreducible minimum.

### Comparison with raw JNI overhead

The 40–47 ns figure for `byIndex = true, readJVM = false` (Sustained, GitHub Actions runner) is worth contextualizing against published raw JNI benchmarks on dedicated hardware. Independent JMH benchmarks measure an empty JNI call at ~57 ns via JavaCPP and ~22 ns on a modern laptop for a minimal no-op native method ([java-native-benchmark](https://github.com/zakgof/java-native-benchmark), [Komanov 2022](https://dkomanov.medium.com/java-native-access-performance-cf4ce0d68ddb)).

JNet's `byIndex = true, readJVM = false` path involves a JVM→CLR crossing (the reverse direction of a JNI call), the numeric index lookup, and the `ShallManageEvent` decision — all on shared CI infrastructure. Reaching 40–47 ns per event in this configuration places JNet within the range of raw JNI call overhead measured on dedicated bare-metal hardware, despite the additional CLR interop layer and the shared runner environment.

---

## Summary

| Test | .NET 8 / T17 | | .NET 10 / T25 | |
|---|---|---|---|---|
| | 2.6.6 | 2.6.7-β6 | 2.6.6 | 2.6.7-β6 |
| Static `Invoke` fb=false | 0.661 µs | 0.509 µs (−23%) | 0.602 µs | 0.463 µs (−23%) |
| Static `IWS` fb=false | 0.494 µs | 0.354 µs (−28%) | 0.414 µs | 0.340 µs (−18%) |
| Static `Invoke` fb=true | 0.901 µs | 0.644 µs (−29%) | 0.803 µs | 0.562 µs (−30%) |
| Static `IWS` fb=true | 0.686 µs | 0.450 µs (−34%) | 0.522 µs | 0.470 µs (−10%) |
| Instance `Invoke` fb=false | 0.579 µs | 0.372 µs (−36%) | 0.490 µs | 0.315 µs (−36%) |
| Instance `IWS` fb=false | 0.468 µs | 0.321 µs (−31%) | 0.379 µs | 0.275 µs (−27%) |
| Instance `Invoke` fb=true | 0.856 µs | 0.571 µs (−33%) | 0.764 µs | 0.529 µs (−31%) |
| Instance `IWS` fb=true | 0.638 µs | 0.458 µs (−28%) | 0.535 µs | 0.500 µs (−6%) |
| Sustained `byIndex=false`, `readJVM=true` | 6.116 µs | 5.195 µs (−15%) | 5.548 µs | 5.043 µs (−9%) |
| Sustained `byIndex=true` ¹, `readJVM=true` | — | 4.557 µs | — | 4.295 µs |
| Sustained `byIndex=false`, `readJVM=false` | — | 0.605 µs | — | 0.498 µs |
| Sustained `byIndex=true` ¹, `readJVM=false` | — | **0.047 µs** | — | **0.040 µs** |

¹ `byIndex = true` simulated on the JVM side in 2.6.7-beta6 — see notes above. No 2.6.6 baseline available.

---

## Guidance

- **Prefer `InvokeWithSignature`** (`IWS`) over `Invoke` in hot paths — it avoids .NET-side type matching on every call and consistently delivers 20–35% lower latency when arguments are involved.
- **The realistic JVM-originated callback reference** is `Sustained, byIndex=false, readJVM=true`: ~5.2 µs (.NET 8 / T17) and ~5.0 µs (.NET 10 / T25) in 2.6.7-beta6. With `byIndex=true` this drops to ~4.6 µs and ~4.3 µs.
- **Use `ShallManageEventHandler`** for high-event-rate sources (AWT components, dense Streams topologies) where many event types have no registered handler. With `byIndex=true`, unhandled events cost ~40–47 ns each — within the range of raw JNI overhead on dedicated hardware.
- **Newer runtimes help**: .NET 10 / Temurin 25 is consistently 5–10% faster than .NET 8 / Temurin 17.
- The `byIndex = true` mechanism will deliver its full benefit on the `readJVM = true` path once the JVM-side simulation is replaced with real interface dispatch.
- If your application runs callbacks at sustained high frequency, consider the [JCOBridge HPA edition](https://www.jcobridge.com) — it addresses GC-boundary instability under sustained JVM↔CLR call pressure, which is the primary reliability concern at high call rates.
