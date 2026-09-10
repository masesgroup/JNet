```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **607.84 ns** |  **4.804 ns** |  **4.494 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **594.51 ns** |  **1.341 ns** |  **1.189 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **787.94 ns** |  **7.627 ns** |  **7.134 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,083.17 ns** | **13.985 ns** | **13.082 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **52.40 ns** |  **1.012 ns** |  **1.039 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **51.95 ns** |  **0.992 ns** |  **1.103 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **241.04 ns** |  **0.320 ns** |  **0.300 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,414.94 ns** | **12.583 ns** | **11.770 ns** | **0.0100** |     **688 B** |
