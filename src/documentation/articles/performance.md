---
title: Performance
_description: Benchmark results for JNet — JVM method invocation and callback latency from .NET
---

# JNet: performance

This page reports benchmark results for the core JNet interop primitives: JVM method invocation from .NET and JVM→.NET callback latency.
All benchmarks run on [GitHub Actions](https://github.com/masesgroup/JNet/actions) runners and are repeated automatically on each release across supported .NET and JDK versions.

Results are reported for three JCOBridge versions — 2.6.6, 2.6.7+, and 2.6.9 — across two runtime combinations. See [JCOBridge release notes](https://www.jcobridge.com/release-notes/) for details.

> [!NOTE]
> Benchmarks are run on shared GitHub-hosted runners. Absolute numbers reflect that environment and should be read comparatively rather than as absolute throughput figures for a dedicated host.

---

## Test environment

| Parameter | Combination A | Combination B |
|---|---|---|
| Runner | GitHub Actions (`ubuntu-22.04`, AMD EPYC 9V45 96-Core) | GitHub Actions (`ubuntu-22.04`, AMD EPYC 9V45 96-Core) |
| Iterations per test | 1 000 000 | 1 000 000 |
| .NET version | .NET 8 | .NET 10 |
| JDK version | Temurin 17 | Temurin 25 |

> [!NOTE]
> The 2.6.6 and 2.6.7+ baselines were collected on earlier `ubuntu-latest` runners and are preserved as historical reference. The 2.6.9 results use `ubuntu-22.04` with AMD EPYC 9V45 — a more consistent environment. Cross-version percentages should be read as directional trends rather than precise measurements.

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
- **`byIndex = true`** — the event is identified on the CLR side by a numeric index. In both cases, JVM object arguments are retrieved as JVM objects after the trigger is received.

**Two-level early-discard filter (`ListenerShallManageEvent`, 2.6.7+):**

JCOBridge 2.6.7+ introduces two overloads of `ListenerShallManageEvent` on the JNet callback base class, forming a two-gate filter applied before full event handling. Both gates receive the event as a numeric index — no string conversion is performed unless explicitly requested via the name-based delegate variants.

**First gate — `bool ListenerShallManageEvent(int eventIndex)`:** called before any argument data is read from the JVM. The return value:
- **`false`** (`continueFirstCheck = false`) — discard immediately: no data is read, the handler is not invoked.
- **`true`** (`continueFirstCheck = true`) — proceed to the second gate.

The first gate is driven by one of the following, evaluated in order:
- `ListenerShallManageEventIndex` (`Func<int, bool>`) — fastest: receives the raw event index, no string conversion.
- `ListenerShallManageEventName` (`Func<string, bool>`) — receives the event name, resolved via `ConvertListenerEventIndexToEventName`.
- Override of `ListenerShallManageEvent(int)` — virtual, for subclass-based filtering.
- Default: returns `true` (all events proceed).

**Second gate — `bool ListenerShallManageEvent(int eventIndex, object data)`:** called after raw argument data is available but before full event processing and handler dispatch. Allows lightweight inspection of the raw payload without paying the cost of full conversion. The return value:
- **`false`** (`continueSecondCheck = false`) — discard after raw-data inspection: the registered handler is not invoked.
- **`true`** (`continueSecondCheck = true`) — proceed normally: full argument conversion and handler invocation.

The second gate is driven by one of the following, evaluated in order:
- `ListenerShallManageEventIndexWithData` (`Func<int, object, bool>`) — receives the raw event index and raw data.
- `ListenerShallManageEventNameWithData` (`Func<string, object, bool>`) — receives the event name and raw data.
- Override of `ListenerShallManageEvent(int, object)` — virtual.
- Default: returns `true`.

The combination `continueFirstCheck = false, continueSecondCheck = true` is never reached and is not tested. Default for both gates is `true` (full processing).

---

## JCOBridge 2.6.6

In 2.6.6, the `ListenerShallManageEvent` filter and the native `byIndex` trigger mechanism are not yet available.

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

| Test | `byIndex` | .NET 8 / T17 | .NET 10 / T25 |
|---|---|---|---|
| `RoundTrip` | `false` | 6.945 µs | 6.338 µs |
| `Sustained` | `false` | 6.116 µs | 5.548 µs |

`Sustained` is the realistic reference for JVM-originated callback cost: **~6.1 µs (.NET 8 / T17) and ~5.5 µs (.NET 10 / T25).**

---

## JCOBridge 2.6.7+

JCOBridge 2.6.7+ introduces the two-level `ListenerShallManageEvent` filter and the native `byIndex` trigger mechanism. General interop improvements reduce baseline overhead across all test types.

> [!NOTE]
> `byIndex = true` is still simulated on the JVM side by invoking a dedicated class method rather than the interface `@Override`. The CLR-side numeric index resolution is fully active; a JVM dispatch difference (class method vs interface method) remains. The `byIndex = false` rows use the real interface override and are directly comparable between versions.

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

JCOBridge 2.6.9 delivers further improvements across all test types through interop layer optimizations, lazy initialization of event data (`TypedEventData`), and a pooled `BatchState` buffer that eliminates per-event array allocation in the dispose fast-scope path. Results collected on `ubuntu-22.04` / AMD EPYC 9V45 96-Core.

> [!NOTE]
> `byIndex = true` is still simulated on the JVM side — see note in the 2.6.7+ section above.

### Static method invocation

| Resolution | `feedback` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|
| `Invoke` | `false` | 0.313 µs | −53% | 0.265 µs | −56% |
| `IWS` | `false` | 0.248 µs | −50% | 0.250 µs | −40% |
| `Invoke` | `true` | 0.471 µs | −48% | 0.482 µs | −40% |
| `IWS` | `true` | 0.311 µs | −55% | 0.305 µs | −42% |

### Instance method invocation

| Resolution | `feedback` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|
| `Invoke` | `false` | 0.189 µs | −67% | 0.176 µs | −64% |
| `IWS` | `false` | 0.162 µs | −65% | 0.178 µs | −53% |
| `Invoke` | `true` | 0.389 µs | −55% | 0.390 µs | −49% |
| `IWS` | `true` | 0.287 µs | −55% | 0.307 µs | −43% |

### Callback: `TestPredicateRoundTrip`

| `byIndex` | `continueFirstCheck` | `continueSecondCheck` | .NET 8 / T17 | vs 2.6.6 | .NET 10 / T25 | vs 2.6.6 |
|---|---|---|---|---|---|---|
| `false` | `false` | `false` | 0.709 µs | −37% | 0.768 µs | −21% |
| `true` ¹ | `false` | `false` | 0.240 µs | — | 0.252 µs | — |
| `false` | `true` | `false` | 1.028 µs | −6% | 0.935 µs | −4% |
| `true` ¹ | `true` | `false` | 0.401 µs | — | 0.451 µs | — |
| `false` | `true` | `true` | 3.157 µs | −55% | 3.278 µs | −48% |
| `true` ¹ | `true` | `true` | 2.607 µs | — | 2.713 µs | — |

¹ `byIndex = true` simulated on the JVM side — see note above.

### Callback: `TestPredicateSustained`

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

The three distinct operating points:

**First gate only (`continueFirstCheck = false`)** — event discarded before any data is read:
- `byIndex = false`: ~0.38–0.37 µs — string key lookup.
- `byIndex = true`: **~35 ns (.NET 8) / ~30 ns (.NET 10)** — `ListenerShallManageEventIndex` path, pure integer check, no string conversion. ~28–33 M events/sec.

**Second gate (`continueFirstCheck = true, continueSecondCheck = false`)** — raw data available for inspection, handler not invoked:
- `byIndex = false`: ~0.51–0.52 µs.
- `byIndex = true`: **~144 ns (.NET 8) / ~152 ns (.NET 10)** — includes raw data retrieval from JVM.

**Full processing (`continueFirstCheck = true, continueSecondCheck = true`)**: ~2.7 µs (`byIndex = false`), ~2.3 µs (`byIndex = true`).

---

## Bulk data transfer at the JVM↔CLR boundary

JCOBridge 2.6.9 enhances `JCOBridgeDirectBuffer<T>` (wrapping a JVM `DirectByteBuffer`) and introduces `JCOBridgeStream<T>` (wrapping a JVM native array), both with `T : unmanaged`. Both types expose `ToStream()` (backed by `UnmanagedMemoryStream`), `ReadOnlySpan<T>`, and .NET Framework-compatible shims.

> [!NOTE]
> `ReadOnlySpan` and `JCOBridgeStream` zero-copy access requires the **JCOBridge HPA edition**. Without HPA, these paths perform an internal local copy — faster than the full JVM→CLR array transfer for most sizes, but not truly zero-copy. The benchmarks below use the **standard edition**; HPA results will be added when available.

> [!NOTE]
> Tests run in a single process without isolation. Memory is pre-allocated once per size step; 100 iterations measure only access/transfer cost. GC pressure from copy-based APIs is part of the measured cost. Future benchmarks will use DotNetBenchmark with process isolation for statistically rigorous results.

### Array transfer — `JCOBridgeStream<T>`

A JVM `byte[]` of the given size is pre-allocated once per size step. Each iteration retrieves the data via three APIs:

- **`Invoke<byte[]>`** — standard JVM array transfer: allocates a .NET `byte[]` and copies JVM heap memory into it on every call.
- **`AreEqualChunked`** — reads via `JCOBridgeStream<byte>` in 4096-byte chunks, comparing directly against the reference array without allocating a full copy.
- **`AsSpan`** — obtains a `ReadOnlySpan<byte>` from `JCOBridgeStream<byte>` and compares via `SequenceEqual`. In the standard edition an internal local copy is made; with HPA, the array is accessed directly in JVM memory without any copy, with the GC pinned for the duration of the access.

Mean latency per iteration (µs), 100 iterations per size:

| Size | `Invoke<byte[]>` .NET 8 | `AreEqualChunked` .NET 8 | `AsSpan` .NET 8 | `Invoke<byte[]>` .NET 10 | `AreEqualChunked` .NET 10 | `AsSpan` .NET 10 |
|---|---|---|---|---|---|---|
| 10 B | 30.5 | 26.0 | **4.0** | 24.9 | 20.6 | **3.5** |
| 100 B | 3.7 | 6.0 | **2.5** | 1.6 | 4.2 | **1.8** |
| 1 KB | 2.7 | 6.9 | **2.6** | 2.4 | 4.8 | **1.8** |
| 10 KB | 7.5 | 7.3 | **3.7** | 5.5 | 10.1 | **3.0** |
| 100 KB | 84.4 | 87.7 | **81.0** | 67.5 | 66.7 | **61.6** |
| 1 MB | 205.9 | 242.8 | 214.9 | 180.9 | 192.7 | **179.3** |
| 10 MB | 1,843.6 | **1,801.3** | 1,823.1 | 1,540.2 | 1,552.5 | **1,388.3** |
| 100 MB | 14,635.8 | 16,015.4 | **14,384.0** | 13,280.5 | 13,422.4 | **12,624.6** |

Key observations:

- For **small payloads** (≤10 KB), `AsSpan` is **4–8× faster** than `Invoke<byte[]>` — the fixed overhead of the JVM array transfer dominates, and `AsSpan` avoids it even in the standard (non-HPA) edition.
- For **large payloads** (≥1 MB), all three methods converge toward memory bandwidth (~6.8–7.9 GB/s on .NET 10 / T25) — the bottleneck shifts from API overhead to raw data movement.
- `AreEqualChunked` has higher overhead at small sizes due to the chunked read loop but is competitive at large sizes while avoiding a full allocation.
- With **HPA**, `AsSpan` will expose direct access into JVM memory — the small-payload advantage will extend across all sizes.

### ByteBuffer transfer — `JCOBridgeDirectBuffer<T>`

A JVM `DirectByteBuffer` of the given size is pre-allocated once per size step and never recreated during the test. Because a `DirectByteBuffer` lives in native (off-heap) memory from the moment of allocation, reading it from .NET is always a read from a native memory pointer — there is no JVM heap→native copy at any point.

> [!NOTE]
> A real-world `DirectByteBuffer` usage would include JVM-side time to populate the buffer. That cost is not part of this benchmark, which focuses exclusively on the .NET read side.

> [!NOTE]
> `AsSpan` on `JCOBridgeDirectBuffer<T>` accesses the native memory pointer directly and is **independent of the HPA edition** — the buffer already lives outside the JVM heap.

Each iteration accesses the pre-allocated buffer via four APIs:

- **`ToArray`** — allocates a .NET `byte[]` and copies buffer contents into it.
- **`ToStream → AreEqualNaive`** — calls `ToStream()`, wraps it in a `MemoryStream` via `CopyTo`, then `ToArray()` and compares. Allocates a full intermediate copy.
- **`ToStream → AreEqualChunked`** — calls `ToStream()` and reads in 4096-byte chunks. No full intermediate allocation.
- **`AsSpan`** — obtains a `ReadOnlySpan<byte>` directly from the native memory pointer. Zero-copy in all editions.

Mean latency per iteration (µs), 100 iterations per size:

| Size | `ToArray` .NET 8 | `Naive` .NET 8 | `Chunked` .NET 8 | `AsSpan` .NET 8 | `ToArray` .NET 10 | `Naive` .NET 10 | `Chunked` .NET 10 | `AsSpan` .NET 10 |
|---|---|---|---|---|---|---|---|---|
| 10 B | 27.4 | 14.6 | 8.7 | **4.4** | 31.2 | 12.2 | 7.2 | **3.7** |
| 100 B | **2.7** | 5.3 | 6.7 | 2.8 | **2.1** | 4.3 | 6.8 | 2.0 |
| 1 KB | **2.9** | 6.5 | 6.8 | 2.7 | **2.2** | 5.4 | 5.3 | 2.1 |
| 10 KB | 9.7 | 14.5 | 5.5 | **2.7** | 7.7 | 12.0 | 4.6 | **2.3** |
| 100 KB | 82.9 | 61.2 | 11.9 | **5.3** | 64.5 | 44.6 | 9.7 | **4.1** |
| 1 MB | 232.2 | 608.1 | 55.7 | **31.1** | 153.3 | 437.9 | 49.1 | **25.8** |
| 10 MB | 1,792.8 | 6,425.9 | 503.3 | **288.8** | 1,613.6 | 6,254.2 | 433.5 | **251.9** |
| 100 MB | 13,796.8 | 38,873.0 | 7,011.3 | **5,590.3** | 12,608.2 | 35,603.6 | 6,204.5 | **5,407.7** |

Key observations:

- **`ToStream → Naive`** degrades severely at large sizes — full intermediate `MemoryStream` copy. At 100 MB it is **7× slower** than `ToArray`. Avoid for payloads above a few KB.
- **`AsSpan`** is the fastest API for all sizes above 10 KB and is **zero-copy in all editions**. At 100 MB it is **2.5× faster** than `ToArray` on .NET 8 and **2.3× faster** on .NET 10.
- **`ToStream → Chunked`** is a good middle ground: no full intermediate allocation, significantly faster than `Naive` at large sizes.
- At **very small sizes** (100 B – 1 KB), `ToArray` and `AsSpan` are comparable (~2–3 µs) — per-call overhead dominates.

> [!NOTE]
> The ByteBuffer test can be taken as a performance reference for **HPA with native arrays**: because the `DirectByteBuffer` is pre-allocated in native (off-heap) memory and never copied from JVM heap, it represents a scenario where the heap→native copy is absent — exactly what HPA achieves for JVM arrays with its strongest options. Users who currently copy JVM arrays into a `DirectByteBuffer` to avoid heap-to-native overhead can use `JCOBridgeStream<T>` with HPA instead, entering JVM array memory directly without the intermediate buffer.

Effective throughput at 100 MB (standard edition):

| API | .NET 8 / T17 | .NET 10 / T25 |
|---|---|---|
| `ToArray` | 7.2 GB/s | 7.9 GB/s |
| `ToStream → Naive` | 2.6 GB/s | 2.8 GB/s |
| `ToStream → Chunked` | 14.3 GB/s | 16.1 GB/s |
| `AsSpan` | **17.9 GB/s** | **18.5 GB/s** |

---


## Summary

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

### Comparison with raw JNI overhead

The **30–35 ns** figure for `byIndex = true`, first-gate discard (Sustained, 2.6.9) is worth contextualizing against published raw JNI benchmarks on dedicated hardware. Independent JMH benchmarks measure an empty JNI call at ~57 ns via JavaCPP and ~22 ns on a modern laptop for a minimal no-op native method ([java-native-benchmark](https://github.com/zakgof/java-native-benchmark), [Komanov 2022](https://dkomanov.medium.com/java-native-access-performance-cf4ce0d68ddb)).

JNet's first-gate discard path (`ListenerShallManageEventIndex`) involves a JVM→CLR crossing, a numeric index lookup, and an immediate return — all on shared CI infrastructure. Reaching **30–35 ns per event** places JNet within the range of raw JNI call overhead measured on dedicated bare-metal hardware, despite the additional CLR interop layer.

---

## Guidance

- **Prefer `InvokeWithSignature`** (`IWS`) over `Invoke` in hot paths — it avoids .NET-side type matching on every call and consistently delivers 20–55% lower latency when arguments are involved.
- **The realistic JVM-originated callback reference** is `Sustained`, full processing, `byIndex = false`: **~2.7 µs** on both .NET 8 / T17 and .NET 10 / T25 in 2.6.9. With `byIndex = true` this drops to ~2.3 µs.
- **Use the two-level `ListenerShallManageEvent` filter** for high-event-rate sources where only a subset of events require full processing:
  - First gate (`ListenerShallManageEventIndex`) — discard by event index before any data read, no string conversion: **~30–35 ns** with `byIndex = true`.
  - Second gate (`ListenerShallManageEventIndexWithData`) — raw data available for inspection before handler dispatch: **~144–152 ns** with `byIndex = true`.
  - Name-based variants (`ListenerShallManageEventName`, `ListenerShallManageEventNameWithData`) are available when filtering by event name is more convenient; they add the cost of `ConvertListenerEventIndexToEventName`.
- **Newer runtimes help**: .NET 10 / Temurin 25 matches or outperforms .NET 8 / Temurin 17 across most test types, with the largest gains on instance method invocation and the first-gate discard path.
- The `byIndex = true` mechanism will deliver its full benefit on the full-processing path once the JVM-side simulation is replaced with real interface dispatch.
- If your application runs callbacks at sustained high frequency, consider the [JCOBridge HPA edition](https://www.jcobridge.com) — it addresses GC-boundary instability under sustained JVM↔CLR call pressure, which is the primary reliability concern at high call rates.
