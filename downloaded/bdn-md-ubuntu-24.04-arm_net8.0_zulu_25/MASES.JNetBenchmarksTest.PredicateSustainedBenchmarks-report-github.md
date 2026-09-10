```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **602.92 ns** |  **0.949 ns** |  **0.741 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **612.00 ns** |  **0.700 ns** |  **0.546 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **789.96 ns** |  **7.790 ns** |  **7.287 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,211.35 ns** | **77.661 ns** | **72.644 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **49.93 ns** |  **0.299 ns** |  **0.279 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **49.73 ns** |  **0.990 ns** |  **1.100 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **242.46 ns** |  **0.508 ns** |  **0.450 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,434.40 ns** | **40.990 ns** | **38.342 ns** | **0.0100** |     **688 B** |
