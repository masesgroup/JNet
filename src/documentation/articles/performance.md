---
title: Performance
_description: Benchmark results for JNet — JVM method invocation and callback round-trip latency from .NET
---

# JNet: performance

This page reports benchmark results for the core JNet interop primitives: JVM method invocation from .NET and .NET↔JVM callback round-trips.
All benchmarks run on [GitHub Actions](https://github.com/masesgroup/JNet/actions) runners and are repeated automatically on each release across supported .NET and JDK versions.

Results are reported for two JCOBridge versions — 2.6.6 and 2.6.7-beta6 — and two runtime combinations, to show the progression of the interop layer across both the JCOBridge release cycle and the underlying runtime versions. See [JCOBridge release notes](https://www.jcobridge.com/release-notes/) for details.

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

Measures the round-trip latency of calling a JVM method from .NET through JNet, with two resolution strategies:

- **Invoke** — the method is identified by .NET-side type matching against the input arguments on every call. The JVM descriptor is cached after the first resolution, but argument type validation is re-evaluated on the .NET side at each invocation. A more articulated test with complex argument types will show additional overhead from this validation step.
- **InvokeWithSignature** — the method is identified by name and JNI signature string. Argument validation is delegated entirely to the JVM, eliminating the .NET-side type matching cost. Lower and more predictable overhead.

Two method kinds are tested:

- **Static method** — a static JVM method with no arguments and no return value (`void`).
- **Instance method** — an instance method on a JVM object, same signature.

### Callback round-trip (.NET → JVM → .NET)

Measures the full round-trip of a .NET-triggered call that activates a JVM callback class, which in turn invokes back into .NET. This is the pattern used by Kafka Streams `TimestampExtractor`, `Predicate`, `KeyValueMapper`, and similar functional interfaces.

Two axes are combined:

| Axis | Option | Meaning |
|---|---|---|
| Resolution | `byIndex = false` | Legacy mechanism — arguments passed via string key lookup, requires marshalling across the JNI boundary |
| | `byIndex = true` | Native mechanism — arguments passed as native data, no marshalling. Available from JCOBridge 2.6.7. |
| Data read | `readJVM = false` | Callback does not read argument data from JVM — measures pure round-trip overhead only |
| | `readJVM = true` | **Normal JNet behavior** — callback reads argument data from JVM, as in any real implementation |

> [!NOTE]
> `readJVM = false` is an artificial condition introduced in a special test class to isolate the pure round-trip cost. In any real JNet callback implementation, argument data is always retrieved from the JVM — `readJVM = true` is the realistic baseline.

---

## JCOBridge 2.6.6

### Static method invocation

| Resolution | .NET 8 / T17 | .NET 10 / T25 |
|---|---|---|
| `Invoke` | 0.649 µs | 0.599 µs |
| `InvokeWithSignature` | 0.496 µs | 0.428 µs |

### Instance method invocation

| Resolution | .NET 8 / T17 | .NET 10 / T25 |
|---|---|---|
| `Invoke` | 0.554 µs | 0.485 µs |
| `InvokeWithSignature` | 0.456 µs | 0.390 µs |

`InvokeWithSignature` is ~24% faster than `Invoke` on .NET 8 / T17 and ~28% faster on .NET 10 / T25 for static methods; ~18% and ~20% respectively for instance methods.

### Callback round-trip (.NET → JVM → .NET)

In JCOBridge 2.6.6 the native `byIndex = true` mechanism is not yet available. The test infrastructure simulates it by invoking a dedicated class method (`testIndex`) instead of the interface `@Override` (`test`). The `byIndex = true` rows are not directly comparable with `byIndex = false`: any timing difference reflects JVM dispatch type (`invokevirtual` vs `invokeinterface`) rather than the argument passing mechanism.

| `byIndex` | `readJVM` | .NET 8 / T17 | .NET 10 / T25 | Note |
|---|---|---|---|---|
| `false` | `false` | 1.884 µs | 1.777 µs | |
| `true` | `false` | 1.744 µs | 1.674 µs | simulation ¹ |
| `false` | `true` | 7.022 µs | 6.621 µs | realistic baseline |
| `true` | `true` | 6.926 µs | 6.498 µs | simulation ¹ |

¹ `byIndex = true` simulated via class method dispatch — see note above.

The **realistic callback baseline** is **7.0 µs** (.NET 8 / T17) and **6.6 µs** (.NET 10 / T25), giving theoretical ceilings of ~143 K and ~151 K callbacks/sec per thread respectively.

---

## JCOBridge 2.6.7-beta6

JCOBridge 2.6.7 introduces the native `byIndex = true` mechanism on the JNet/.NET side: argument data is now passed as native data without JNI marshalling. The general interop layer also receives performance improvements that reduce baseline overhead across all test types.

> [!NOTE]
> In this version `byIndex = true` is still simulated on the JVM side by invoking a dedicated class method (`testIndex`) rather than the interface `@Override` (`test`). The native argument passing path is active on the JNet/.NET side; the JVM dispatch difference (class method vs interface method) remains. The `byIndex = false` rows use the real interface override and are directly comparable between the two versions.

### Static method invocation

| Resolution | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|
| `Invoke` | 0.459 µs | −29% | 0.468 µs | −22% |
| `InvokeWithSignature` | 0.345 µs | −30% | 0.336 µs | −21% |

### Instance method invocation

| Resolution | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|
| `Invoke` | 0.332 µs | −40% | 0.307 µs | −37% |
| `InvokeWithSignature` | 0.283 µs | −38% | 0.283 µs | −27% |

`InvokeWithSignature` is ~25% faster than `Invoke` on .NET 8 / T17 and ~28% faster on .NET 10 / T25 for static methods; ~15% and ~8% respectively for instance methods.

### Callback round-trip (.NET → JVM → .NET)

| `byIndex` | `readJVM` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|
| `false` | `false` | 1.114 µs | −41% | 1.084 µs | −39% |
| `true` ¹ | `false` | 0.413 µs | −76% | 0.450 µs | −73% |
| `false` | `true` | 6.177 µs | −12% | 5.640 µs | −15% |
| `true` ¹ | `true` | 5.516 µs | −20% | 4.866 µs | −25% |

¹ `byIndex = true` simulated via class method dispatch — see note above.

The **realistic callback baseline** is **6.2 µs** (.NET 8 / T17) and **5.6 µs** (.NET 10 / T25), giving theoretical ceilings of ~162 K and ~177 K callbacks/sec per thread — improvements of 12% and 17% respectively over 2.6.6.

The `byIndex = true` rows show a dramatic drop in pure round-trip latency (−76% / −73% on `readJVM = false`): the native argument passing eliminates marshalling almost entirely, bringing pure dispatch overhead from ~1.1 µs down to ~0.4 µs. With `readJVM = true` the gain is more contained (−20% / −25%) because JVM data read cost still dominates — and there the newer runtime (T25) shows a larger benefit.

---

## Summary comparison

| Test | .NET 8 / T17 2.6.6 | .NET 8 / T17 2.6.7-β6 | Δ | .NET 10 / T25 2.6.6 | .NET 10 / T25 2.6.7-β6 | Δ |
|---|---|---|---|---|---|---|
| Static `Invoke` | 0.649 µs | 0.459 µs | −29% | 0.599 µs | 0.468 µs | −22% |
| Static `InvokeWithSignature` | 0.496 µs | 0.345 µs | −30% | 0.428 µs | 0.336 µs | −21% |
| Instance `Invoke` | 0.554 µs | 0.332 µs | −40% | 0.485 µs | 0.307 µs | −37% |
| Instance `InvokeWithSignature` | 0.456 µs | 0.283 µs | −38% | 0.390 µs | 0.283 µs | −27% |
| Callback `byIndex=false`, `readJVM=false` | 1.884 µs | 1.114 µs | −41% | 1.777 µs | 1.084 µs | −39% |
| Callback `byIndex=true` ¹, `readJVM=false` | 1.744 µs | 0.413 µs | −76% | 1.674 µs | 0.450 µs | −73% |
| Callback `byIndex=false`, `readJVM=true` | 7.022 µs | 6.177 µs | −12% | 6.621 µs | 5.640 µs | −15% |
| Callback `byIndex=true` ¹, `readJVM=true` | 6.926 µs | 5.516 µs | −20% | 6.498 µs | 4.866 µs | −25% |

¹ `byIndex = true` is simulated on the JVM side in both versions — see notes above.

---

## Guidance

- For **tight loops over JVM methods**, prefer `InvokeWithSignature` — it delegates argument validation to the JVM and avoids the .NET-side type matching cost. The advantage will widen in future tests with complex argument types.
- The **realistic callback baseline** is the `readJVM = true` row: in any real JNet implementation argument data is always retrieved from the JVM. On 2.6.7-beta6 this stands at ~6.2 µs (.NET 8 / T17) and ~5.6 µs (.NET 10 / T25).
- The `byIndex = true` native mechanism, fully effective in 2.6.7+, will bring the `readJVM = true` baseline significantly lower once the JVM-side simulation is replaced with the real interface dispatch path.
- The ~0.3–0.5 µs baseline for direct method invocation reflects the irreducible JNI boundary cost on a GitHub Actions runner. On a dedicated host with pinned cores absolute numbers will be lower, but the relative ordering between strategies holds.
- If your application runs callbacks at sustained high frequency, consider the [JCOBridge HPA edition](https://www.jcobridge.com) — it addresses GC-boundary instability under sustained JVM↔CLR call pressure, which is the primary reliability concern at high call rates.
