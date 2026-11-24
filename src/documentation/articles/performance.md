---
title: Performance
_description: Benchmark results for JNet — JVM method invocation and callback latency from .NET
---

# JNet: performance

This page reports benchmark results for the core JNet interop primitives: JVM method invocation from .NET and JVM→.NET callback latency.
All benchmarks run on [GitHub Actions](https://github.com/masesgroup/JNet/actions) runners and are repeated automatically on each release across supported .NET and JDK versions.

> [!NOTE]
> Benchmarks are run on shared GitHub-hosted runners. Absolute numbers reflect that environment and should be read comparatively rather than as absolute throughput figures for a dedicated host.

## Current results

Median across the CI matrix for each CPU class; below each median, the interquartile range (IQR) and the best run observed. The spread reflects differences between OS, .NET, JDK and runner hardware, not measurement noise. The x64 columns group runners by the instruction set the runtime detected, so CPU models within a column still vary. Results per CPU model, with allocations, are in [Benchmark results by CPU model](benchmark-by-cpu.md).

<!-- BENCHMARK-SUMMARY-START -->

| Benchmark | arm64, 92 runs | x64 AVX2 (v3), 31 runs | x64 AVX-512 (v4), 61 runs |
|---|---:|---:|---:|
| Sustained JVM→.NET callback (first gate discard) | **45.02 ns**<br><sub>IQR 44.21 – 46.92 ns · best 42.29 ns</sub> | **34.05 ns**<br><sub>IQR 31.55 – 35.08 ns · best 28.69 ns</sub> | **35.52 ns**<br><sub>IQR 28.18 – 37.29 ns · best 23.61 ns</sub> |
| Sustained JVM→.NET callback (full processing) | **2,591.82 ns**<br><sub>IQR 2,527.83 – 2,665.69 ns · best 2,062.38 ns</sub> | **3,018.86 ns**<br><sub>IQR 2,577.13 – 3,082.92 ns · best 2,249.11 ns</sub> | **1,790.07 ns**<br><sub>IQR 1,743.20 – 2,073.11 ns · best 1,556.32 ns</sub> |
| Static no-arg invocation | **150.5 ns**<br><sub>IQR 145.6 – 155.1 ns · best 111.6 ns</sub> | **143.1 ns**<br><sub>IQR 137.4 – 153.1 ns · best 122.0 ns</sub> | **84.07 ns**<br><sub>IQR 72.55 – 115.1 ns · best 69.80 ns</sub> |
| Static invocation with feedback | **514.4 ns**<br><sub>IQR 504.7 – 520.7 ns · best 389.8 ns</sub> | **539.8 ns**<br><sub>IQR 427.7 – 559.5 ns · best 402.3 ns</sub> | **287.84 ns**<br><sub>IQR 263.53 – 379.3 ns · best 250.03 ns</sub> |
| Object creation | **796.0 ns**<br><sub>IQR 785.4 – 808.6 ns · best 696.4 ns</sub> | **860.6 ns**<br><sub>IQR 725.7 – 915.2 ns · best 683.2 ns</sub> | **538.3 ns**<br><sub>IQR 515.4 – 663.5 ns · best 485.3 ns</sub> |
| Invoke with int[] (10000 elements) | **6,186.2 ns**<br><sub>IQR 6,142.3 – 6,239.9 ns · best 3,580.4 ns</sub> | **7,900.0 ns**<br><sub>IQR 7,644.6 – 8,043.9 ns · best 5,324.5 ns</sub> | **6,027.9 ns**<br><sub>IQR 5,628.1 – 7,706.3 ns · best 2,474.6 ns</sub> |
| Get instance int field | **65.66 ns**<br><sub>IQR 63.69 – 68.75 ns · best 57.29 ns</sub> | **73.65 ns**<br><sub>IQR 55.10 – 75.48 ns · best 48.36 ns</sub> | **39.31 ns**<br><sub>IQR 33.48 – 53.26 ns · best 30.42 ns</sub> |
| Set instance int field | **94.78 ns**<br><sub>IQR 90.19 – 97.98 ns · best 79.16 ns</sub> | **80.24 ns**<br><sub>IQR 64.42 – 83.02 ns · best 55.56 ns</sub> | **48.24 ns**<br><sub>IQR 41.15 – 61.38 ns · best 37.95 ns</sub> |
| Get instance string field | **84.15 ns**<br><sub>IQR 81.02 – 87.30 ns · best 70.90 ns</sub> | **71.89 ns**<br><sub>IQR 55.63 – 74.18 ns · best 50.78 ns</sub> | **44.96 ns**<br><sub>IQR 36.08 – 52.60 ns · best 33.47 ns</sub> |
| Set instance string field | **537.41 ns**<br><sub>IQR 529.24 – 543.01 ns · best 452.90 ns</sub> | **542.34 ns**<br><sub>IQR 446.10 – 587.19 ns · best 388.73 ns</sub> | **345.75 ns**<br><sub>IQR 303.22 – 399.62 ns · best 285.32 ns</sub> |

<!-- BENCHMARK-SUMMARY-END -->

Terms used in the tables:

- **`Invoke` / `IWS`** (`InvokeWithSignature`): the method is resolved by .NET-side type matching, or by name and JNI signature.
- **`feedback`**: `false` is a no-argument `void` method; `true` takes and returns a `boolean`.
- **`byIndex`**: the callback event is identified by a numeric index (`true`) or by a string key (`false`). Since JCOBridge 2.6.10 the two are practically equivalent: the index is resolved once and used as the key of a hashmap.
- **First / second gate**: the two-level `ListenerShallManageEvent` filter; the first gate discards an event before any data is read, the second after the raw data is available.
- **`Sustained`**: the JVM fires 1,000,000 callbacks toward .NET without returning control.
- **`T17` / `T25`**: Temurin 17 / Temurin 25. **`fb`**: `feedback`.
- **`continueFirstCheck` / `continueSecondCheck`**: whether the event passes the first / second gate (`false` = discarded there).
- **`TestPredicateRoundTrip`**: .NET triggers a JVM call that immediately fires a callback back into .NET. In real usage the JVM initiates the event, so `Sustained` is the realistic reference.

For the full BenchmarkDotNet results across all supported .NET versions, JDK vendors, and platforms see:

- [Latest benchmark results](benchmark-latest.md)
- [Live benchmark dashboard](https://masesgroup.com/benchmark-data/)

---

## Historical analysis

The sections below are a historical analysis across JCOBridge 2.6.6, 2.6.7+ and 2.6.9. 
The data were collected at different times, on different runners and hardware, so do not read them as absolute figures and do not compare them with the current results above. 
Read them as guidance on how to use the tool: which strategies cost more, how costs scale and what to avoid in hot paths.

### Test environments

Three environments are used across this page:

| Parameter | x86-64 EPYC (stopwatch) | x86-64 (BenchmarkDotNet) | ARM64 (BenchmarkDotNet) |
|---|---|---|---|
| Runner | GitHub Actions `ubuntu-22.04`, AMD EPYC 9V45 96-Core | GitHub Actions `ubuntu-24.04`, AMD EPYC 7763 2-Core | GitHub Actions `ubuntu-24.04`, Neoverse-N2 4-Core |
| Measurement | Stopwatch, 1 000 000 iterations | BenchmarkDotNet, statistically rigorous | BenchmarkDotNet, statistically rigorous |
| .NET versions | .NET 8 / .NET 10 | .NET 8 / .NET 10 | .NET 8 / .NET 10 |
| JDK versions | Temurin 17 / Temurin 25 | Multiple vendors — see [Latest benchmark results](benchmark-latest.md) | Multiple vendors — see [Latest benchmark results](benchmark-latest.md) |

> [!NOTE]
> The 2.6.6 and 2.6.7+ baselines were collected on earlier `ubuntu-latest` runners and are preserved as historical reference. The x86-64 EPYC stopwatch results (2.6.9 section) use the AMD EPYC 9V45 dedicated runner and represent the lowest latency observed on x86-64. The BenchmarkDotNet results use shared `ubuntu-24.04` runners on both platforms and are statistically rigorous; see the [live dashboard](https://masesgroup.com/benchmark-data/) for up-to-date numbers.

---

### JCOBridge 2.6.7+

JCOBridge 2.6.7+ introduces the two-level `ListenerShallManageEvent` filter and the native `byIndex` trigger mechanism. General interop improvements reduce baseline overhead across all test types.

> [!NOTE]
> `byIndex = true` is still simulated on the JVM side by invoking a dedicated class method rather than the interface `@Override`. The CLR-side numeric index resolution is fully active; a JVM dispatch difference (class method vs interface method) remains. The `byIndex = false` rows use the real interface override and are directly comparable between versions.

#### Static method invocation

| Resolution | `feedback` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|
| `Invoke` | `false` | 0.517 µs | −22% | 0.480 µs | −20% |
| `IWS` | `false` | 0.356 µs | −28% | 0.335 µs | −19% |
| `Invoke` | `true` | 0.609 µs | −32% | 0.575 µs | −28% |
| `IWS` | `true` | 0.435 µs | −37% | 0.419 µs | −20% |

#### Instance method invocation

| Resolution | `feedback` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|
| `Invoke` | `false` | 0.349 µs | −40% | 0.301 µs | −39% |
| `IWS` | `false` | 0.295 µs | −37% | 0.274 µs | −28% |
| `Invoke` | `true` | 0.552 µs | −36% | 0.511 µs | −33% |
| `IWS` | `true` | 0.448 µs | −30% | 0.452 µs | −15% |

#### Callback: `TestPredicateRoundTrip`

| `byIndex` | `continueFirstCheck` | `continueSecondCheck` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|---|
| `false` | `false` | `false` | 1.106 µs | — | 1.040 µs | — |
| `true` ¹ | `false` | `false` | 0.452 µs | — | 0.435 µs | — |
| `false` | `true` | `false` | 1.126 µs | — | 1.074 µs | — |
| `true` ¹ | `true` | `false` | 0.502 µs | — | 0.456 µs | — |
| `false` | `true` | `true` | 5.794 µs | −16% | 5.318 µs | −16% |
| `true` ¹ | `true` | `true` | 5.023 µs | −28% | 4.628 µs | −27% |

¹ `byIndex = true` simulated on the JVM side — see note above.

#### Callback: `TestPredicateSustained`

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

### JCOBridge 2.6.9

JCOBridge 2.6.9 delivers further improvements across all test types through interop layer optimizations, lazy initialization of event data (`TypedEventData`), and a pooled `BatchState` buffer that eliminates per-event array allocation in the dispose fast-scope path. Results collected on `ubuntu-22.04` / AMD EPYC 9V45 96-Core.

> [!NOTE]
> `byIndex = true` is still simulated on the JVM side — see note in the 2.6.7+ section above.

#### Static method invocation

| Resolution | `feedback` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|
| `Invoke` | `false` | 0.313 µs | −53% | 0.265 µs | −56% |
| `IWS` | `false` | 0.248 µs | −50% | 0.250 µs | −40% |
| `Invoke` | `true` | 0.471 µs | −48% | 0.482 µs | −40% |
| `IWS` | `true` | 0.311 µs | −55% | 0.305 µs | −42% |

#### Instance method invocation

| Resolution | `feedback` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|
| `Invoke` | `false` | 0.189 µs | −67% | 0.176 µs | −64% |
| `IWS` | `false` | 0.162 µs | −65% | 0.178 µs | −53% |
| `Invoke` | `true` | 0.389 µs | −55% | 0.390 µs | −49% |
| `IWS` | `true` | 0.287 µs | −55% | 0.307 µs | −43% |

#### Callback: `TestPredicateRoundTrip`

| `byIndex` | `continueFirstCheck` | `continueSecondCheck` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|---|
| `false` | `false` | `false` | 0.709 µs | −37% | 0.768 µs | −21% |
| `true` ¹ | `false` | `false` | 0.240 µs | — | 0.252 µs | — |
| `false` | `true` | `false` | 1.028 µs | −6% | 0.935 µs | −4% |
| `true` ¹ | `true` | `false` | 0.401 µs | — | 0.451 µs | — |
| `false` | `true` | `true` | 3.157 µs | −55% | 3.278 µs | −48% |
| `true` ¹ | `true` | `true` | 2.607 µs | — | 2.713 µs | — |

¹ `byIndex = true` simulated on the JVM side — see note above.

#### Callback: `TestPredicateSustained`

| `byIndex` | `continueFirstCheck` | `continueSecondCheck` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|---|
| `false` | `false` | `false` | 0.379 µs | −94% | 0.366 µs | −93% |
| `true` ¹ | `false` | `false` | **0.035 µs** | — | **0.030 µs** | — |
| `false` | `true` | `false` | 0.505 µs | −92% | 0.522 µs | −91% |
| `true` ¹ | `true` | `false` | **0.144 µs** | — | **0.152 µs** | — |
| `false` | `true` | `true` | 2.674 µs | −56% | 2.750 µs | −50% |
| `true` ¹ | `true` | `true` | 2.324 µs | — | 2.278 µs | — |

¹ `byIndex = true` simulated on the JVM side — see note above.

The **realistic JVM-originated callback baseline** (full processing, `byIndex = false`) reaches **2.7 µs on both .NET 8 and .NET 10** — a **−56%** reduction over 2.6.6.

#### Callback: BenchmarkDotNet comparison (`ubuntu-24.04`, Temurin 17 / Temurin 25)

`TestPredicateSustained` results. For full multi-vendor breakdown see [Latest benchmark results](benchmark-latest.md).

| `byIndex` | `continueFirstCheck` | `continueSecondCheck` | x86-64 .NET 8 / T17 | x86-64 .NET 10 / T25 | ARM64 .NET 8 / T17 | ARM64 .NET 10 / T25 |
|---|---|---|---|---|---|---|
| `false` | `false` | `false` | 511.5 ns | 497.2 ns | 574.8 ns | 584.7 ns |
| `true` ¹ | `false` | `false` | **40.0 ns** | **30.5 ns** | **44.2 ns** | **42.6 ns** |
| `false` | `true` | `false` | 689.2 ns | 692.8 ns | 781.4 ns | 800.4 ns |
| `true` ¹ | `true` | `false` | **185.6 ns** | **204.4 ns** | **262.9 ns** | **255.7 ns** |
| `false` | `true` | `true` | 3,917.6 ns | 4,081.8 ns | 4,059.6 ns | 4,514.7 ns |
| `true` ¹ | `true` | `true` | 3,263.7 ns | 3,133.3 ns | 3,611.1 ns | 3,627.0 ns |

¹ `byIndex = true` simulated on the JVM side — see note in the 2.6.7+ section.

The **x86-64 first-gate** (`byIndex = true, F,F`) reaches **30.5 ns** on .NET 10 / T25 — identical to the x86-64 EPYC stopwatch result (~30–35 ns) and confirming the measurement across two independent methodologies. ARM64 first-gate is **42–44 ns**. Full processing on both platforms converges at ~3.1–4.5 µs (BenchmarkDotNet shared runner), with the EPYC stopwatch showing lower numbers (~2.3–2.7 µs) reflecting dedicated hardware advantage.

The three distinct operating points:

**First gate only (`continueFirstCheck = false`)** — event discarded before any data is read:
- `byIndex = false`: ~0.38–0.37 µs — string key lookup.
- `byIndex = true`: **~35 ns (.NET 8) / ~30 ns (.NET 10)** — `ListenerShallManageEventIndex` path, pure integer check, no string conversion. ~28–33 M events/sec.

**Second gate (`continueFirstCheck = true, continueSecondCheck = false`)** — raw data available for inspection, handler not invoked:
- `byIndex = false`: ~0.51–0.52 µs.
- `byIndex = true`: **~144 ns (.NET 8) / ~152 ns (.NET 10)** — includes raw data retrieval from JVM.

**Full processing (`continueFirstCheck = true, continueSecondCheck = true`)**: ~2.7 µs (`byIndex = false`), ~2.3 µs (`byIndex = true`).

---

### Bulk data transfer at the JVM↔CLR boundary

JCOBridge 2.6.9 introduces `JCOBridgeDirectBuffer<T>` (wrapping a JVM `DirectByteBuffer`) and `JCOBridgeStream<T>` (wrapping a JVM native array), both with `T : unmanaged`. Both types expose `ToStream()` (backed by `UnmanagedMemoryStream`), `ReadOnlySpan<T>`, and .NET Framework-compatible shims.

> [!NOTE]
> Tests run in a single process without isolation. Memory is pre-allocated once per size step; 100 iterations measure only access/transfer cost. Future benchmarks will use DotNetBenchmark with process isolation for statistically rigorous results.

---

#### Array transfer — `JCOBridgeStream<T>`

A JVM `byte[]` of the given size is pre-allocated once per size step. Each iteration retrieves the data via three APIs:

- **`Invoke<byte[]>`** — allocates a .NET `byte[]` and copies JVM array data into it. Behavior is the same in both standard and HPA editions; the underlying transfer path can be switched to a lower-overhead mode for small arrays (see below).
- **`AreEqualChunked`** — reads via `JCOBridgeStream<byte>` in 4096-byte chunks without allocating a full copy.
- **`AsSpan`** — obtains a `ReadOnlySpan<byte>` from `JCOBridgeStream<byte>`:
  - **Standard edition**: performs an internal copy regardless of `forceRawMemory` (`forceRawMemory` is a no-op in standard)
  - **HPA, `forceRawMemory=false`**: accesses JVM array memory directly — **no copy**
  - **HPA, `forceRawMemory=true`**: accesses JVM array memory with GC pinned for the duration — **no copy, lowest latency for large arrays**; use with care (no JVM allocations or blocking operations during the pinned window)

##### Standard edition — `AsSpan` latency (µs, 100 iterations, default path / optimized path)

The optimized transfer path reduces per-call overhead for **small arrays** dramatically. For large arrays (≥1 MB) the bottleneck shifts to memory bandwidth and the optimized path offers no advantage.

| Size | `.NET 8` default | `.NET 8` optimized | `.NET 10` default | `.NET 10` optimized |
|---|---|---|---|---|
| 10 B | 6.3 | **1.4** | 6.8 | **1.5** |
| 1 KB | 3.5 | **1.4** | 2.5 | **1.1** |
| 10 KB | 4.3 | **2.6** | 3.6 | **1.6** |
| 100 KB | 77.2 | 59.6 | 79.6 | 62.6 |
| 1 MB | 289.2 | 212.8 | 248.7 | 192.2 |
| 10 MB | 2,152.6 | 2,213.4 | 1,449.3 | 1,501.9 |
| 100 MB | 35,962.8 | 59,541.3 | 14,958.8 | 20,502.4 |

The optimized path is beneficial only for small arrays (≤100 KB). For large arrays it can be slower due to GC interaction — use the default path at scale.

##### HPA edition — `AsSpan` latency (µs, 100 iterations, before optimized path)

| Size | Standard | HPA `forceRaw=false` | HPA `forceRaw=true` | vs Standard |
|---|---|---|---|---|
| 10 B .NET 8 | 6.3 | 5.1 | **4.7** | −25% |
| 100 KB .NET 8 | 77.2 | 10.0 | **8.3** | **−89%** |
| 1 MB .NET 8 | 289.2 | 84.7 | **46.8** | **−84%** |
| 10 MB .NET 8 | 2,152.6 | 764.2 | **270.8** | **−87%** |
| 100 MB .NET 8 | 35,962.8 | 17,830.0 | **6,019.2** | **−83%** |
| 100 KB .NET 10 | 79.6 | 12.6 | **9.2** | **−88%** |
| 1 MB .NET 10 | 248.7 | 134.6 | **74.4** | **−70%** |
| 10 MB .NET 10 | 1,449.3 | 858.2 | **314.6** | **−78%** |
| 100 MB .NET 10 | 14,958.8 | 15,826.7 | **5,626.6** | **−62%** |

Key observations:

- **`forceRawMemory=false`** eliminates the copy for ≥100 KB: −87/−88% at 100 KB, −84/−70% at 1 MB vs standard. For small arrays (≤10 KB) the difference is minor — overhead is dominated by per-call cost, not data movement.
- **`forceRawMemory=true`** goes further: −83/−62% at 100 MB vs standard — the fastest path for large arrays. The additional gain over `forceRawMemory=false` is largest at 10 MB+ where the pinned access eliminates all intermediate buffering.
- For **small arrays** (≤10 KB), all HPA paths are similar to standard — per-call overhead dominates over data transfer cost. Use the optimized transfer path (see standard table above) for small sizes.

---

#### ByteBuffer transfer — `JCOBridgeDirectBuffer<T>`

The benchmark reflects real-world usage: each iteration calls `getByteBuffer()` on the JVM side, which copies the pre-allocated array into a `DirectByteBuffer` before returning it to .NET. This includes both the JVM-side copy cost (heap → native memory) and the .NET-side read cost.

> [!NOTE]
> `JCOBridgeDirectBuffer<T>` and `EnableCritical` / `forceRawMemory` have **no effect** on ByteBuffer access — a `DirectByteBuffer` already lives in native memory and is always accessed via direct pointer in both standard and HPA editions. Standard and HPA produce identical results.

| Size | `ToArray` .NET 8 | `AsSpan` .NET 8 | `ToArray` .NET 10 | `AsSpan` .NET 10 |
|---|---|---|---|---|
| 10 B | 198.5 µs | 9.8 µs | 192.5 µs | 8.9 µs |
| 100 B | 8.4 µs | 4.7 µs | 8.4 µs | 4.2 µs |
| 1 KB | 6.5 µs | 4.4 µs | 6.1 µs | 4.5 µs |
| 10 KB | 13.9 µs | 5.3 µs | 15.3 µs | 5.7 µs |
| 100 KB | 93.4 µs | 12.3 µs | 90.6 µs | 13.5 µs |
| 1 MB | 552.0 µs | 88.9 µs | 398.0 µs | 103.8 µs |
| 10 MB | 2,674.0 µs | 881.8 µs | 2,535.6 µs | 815.8 µs |
| 100 MB | 44,096.1 µs | **13,474.7 µs** | 20,339.0 µs | **11,742.0 µs** |

- **`AsSpan`** is consistently fastest: reads the native memory pointer directly with no .NET allocation.
- **`ToArray`** at 10 B is expensive (198 µs) because `getByteBuffer()` has per-call JVM overhead that dominates at small sizes — `getArray()` + `Invoke<byte[]>` is faster for small payloads.
- **`ToStream → Naive`** (full intermediate MemoryStream copy) is the slowest for large sizes — avoid above a few KB.

> [!NOTE]
> **ByteBuffer vs HPA array access**: the `AsSpan` ByteBuffer cost at 100 MB (~13.5 ms on .NET 8) reflects two components: the JVM-side copy from heap to native memory (~7.5 ms) and the .NET read from native memory (~6 ms). The .NET read portion matches `JCOBridgeStream AsSpan` with HPA `forceRawMemory=true` (~6 ms), confirming that both operations ultimately read from native memory at the same speed. The ByteBuffer pattern adds the JVM-side copy overhead that HPA array access avoids entirely.

---


### Summary

| Test | .NET 8 / T17 | | | .NET 10 / T25 | | |
|---|---|---|---|---|---|---|
| | 2.6.6 | 2.6.7+ | 2.6.9 | 2.6.6 | 2.6.7+ | 2.6.9 |
| Static `Invoke` fb=false | 0.661 | 0.517 (−22%) | 0.313 (−53%) | 0.602 | 0.480 (−20%) | 0.265 (−56%) |
| Static `IWS` fb=false | 0.494 | 0.356 (−28%) | 0.248 (−50%) | 0.414 | 0.335 (−19%) | 0.250 (−40%) |
| Static `Invoke` fb=true | 0.901 | 0.609 (−32%) | 0.471 (−48%) | 0.803 | 0.575 (−28%) | 0.482 (−40%) |
| Static `IWS` fb=true | 0.686 | 0.435 (−37%) | 0.311 (−55%) | 0.522 | 0.419 (−20%) | 0.305 (−42%) |
| Instance `Invoke` fb=false | 0.579 | 0.349 (−40%) | 0.189 (−67%) | 0.490 | 0.301 (−39%) | 0.176 (−64%) |
| Instance `IWS` fb=false | 0.468 | 0.295 (−37%) | 0.162 (−65%) | 0.379 | 0.274 (−28%) | 0.178 (−53%) |
| Instance `Invoke` fb=true | 0.856 | 0.552 (−36%) | 0.389 (−55%) | 0.764 | 0.511 (−33%) | 0.390 (−49%) |
| Instance `IWS` fb=true | 0.638 | 0.448 (−30%) | 0.287 (−55%) | 0.535 | 0.452 (−15%) | 0.307 (−43%) |
| Sustained: full, `byIndex=false` | 6.116 | 5.098 (−17%) | 2.674 (−56%) | 5.548 | 4.725 (−15%) | 2.750 (−50%) |
| Sustained: full, `byIndex=true` ¹ | — | 4.467 | 2.324 | — | 4.141 | 2.278 |
| Sustained: 1st gate, `byIndex=false` | — | 0.601 | 0.379 | — | 0.468 | 0.366 |
| Sustained: 1st gate, `byIndex=true` ¹ | — | **0.045** | **0.035** | — | **0.041** | **0.030** |
| Sustained: 2nd gate, `byIndex=false` | — | 0.625 | 0.505 | — | 0.493 | 0.522 |
| Sustained: 2nd gate, `byIndex=true` ¹ | — | **0.074** | **0.144** | — | **0.067** | **0.152** |

All values in µs. Percentages vs 2.6.6 where available. ¹ `byIndex = true` simulated on the JVM side.

#### Comparison with raw JNI overhead

The **30–35 ns** figure for `byIndex = true`, first-gate discard (Sustained, 2.6.9) is worth contextualizing against published raw JNI benchmarks on dedicated hardware. Independent JMH benchmarks measure an empty JNI call at ~57 ns via JavaCPP and ~22 ns on a modern laptop for a minimal no-op native method ([java-native-benchmark](https://github.com/zakgof/java-native-benchmark), [Komanov 2022](https://dkomanov.medium.com/java-native-access-performance-cf4ce0d68ddb)).

JNet's first-gate discard path (`ListenerShallManageEventIndex`) involves a JVM→CLR crossing, a numeric index lookup, and an immediate return — all on shared CI infrastructure. Reaching **30–35 ns per event** places JNet within the range of raw JNI call overhead measured on dedicated bare-metal hardware, despite the additional CLR interop layer.

---

### Guidance

- **Prefer `InvokeWithSignature`** (`IWS`) over `Invoke` in hot paths on x86 — it avoids .NET-side type matching and consistently delivers 20–55% lower latency with arguments involved. On ARM64 the two strategies are nearly equivalent for no-argument methods; the advantage of `IWS` varies by JDK vendor (see [dashboard](https://masesgroup.com/benchmark-data/)).
- **Constructor resolution strategy does not matter**: `NewEmpty`, `NewWithSignature` and `DeclaredNewEmpty` are within a few percent of each other. Choose whichever is most readable.
- **Primitive field access is cheap; string field writes are not**: setting a JVM `String` field costs roughly 7× the corresponding read and allocates on the .NET side. Avoid repeated `String` field writes in hot paths; prefer `int`/`long`/`boolean` fields or aggregate string data into a single call.
- **Never pass large `String[]` arrays in hot paths**: every element is marshalled individually, so the cost is hundreds of times that of an equivalent `int[]`. Prefer primitive arrays, or use `JCOBridgeStream<T>` for binary bulk transfer.
- **Varargs with spread elements** are the worst case for per-element overhead, because each argument is individually boxed. Pass arrays as arrays when the element count is large.
- **Multi-parameter invocation** costs several times a no-argument call. Keep argument lists short for frequently called methods.
- **The realistic JVM-originated callback reference** is `Sustained`, full processing, `byIndex = false`: **~2.7 µs** on x86 EPYC (2.6.9), **~4.1–4.5 µs** on ARM64 Neoverse-N2.
- **Use the two-level `ListenerShallManageEvent` filter** for high-event-rate sources:
  - First gate (`ListenerShallManageEventIndex`) — discard before any data read: **~30–35 ns** (x86), **~42–44 ns** (ARM64).
  - Second gate (`ListenerShallManageEventIndexWithData`) — inspect raw data before handler: **~144–152 ns** (x86), **~256–263 ns** (ARM64).
- **For bulk data from JVM arrays**, prefer `JCOBridgeStream<T>` with HPA `forceRawMemory=true` for large payloads — up to 83% faster than standard at 100 MB. For small arrays (≤10 KB), the optimized transfer path reduces per-call overhead to ~1–2 µs.
- **For `DirectByteBuffer` access**, use `AsSpan` — zero-copy from native memory in all editions, ~16 GB/s at 100 MB. Avoid `ToStream → Naive` above a few KB.
- From JCOBridge 2.6.10 `byIndex = true` and `byIndex = false` are practically equivalent (the index is resolved once and looked up in a key-value hashmap), so the gap between them in the historical tables above no longer applies.
- If your application runs callbacks at sustained high frequency, consider the [JCOBridge HPA edition](https://www.jcobridge.com) — it addresses GC-boundary instability under sustained JVM↔CLR call pressure and enables true zero-copy bulk array access.

Current numbers for all of these are in [Benchmark results by CPU model](benchmark-by-cpu.md).