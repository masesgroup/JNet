```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **584.25 ns** |  **0.941 ns** |  **0.735 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **590.81 ns** |  **0.846 ns** |  **0.660 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **797.04 ns** |  **4.943 ns** |  **4.624 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,035.20 ns** | **36.356 ns** | **34.008 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **48.82 ns** |  **0.803 ns** |  **0.825 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **50.12 ns** |  **0.314 ns** |  **0.279 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **238.27 ns** |  **0.578 ns** |  **0.541 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,358.34 ns** | **19.665 ns** | **18.395 ns** | **0.0100** |     **688 B** |
