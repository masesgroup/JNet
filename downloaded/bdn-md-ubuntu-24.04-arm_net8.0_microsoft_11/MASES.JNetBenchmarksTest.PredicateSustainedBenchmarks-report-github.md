```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **622.37 ns** |  **5.261 ns** |  **4.921 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **630.82 ns** |  **1.443 ns** |  **1.279 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **799.86 ns** |  **0.745 ns** |  **0.661 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,281.62 ns** | **12.109 ns** | **11.326 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **59.12 ns** |  **1.157 ns** |  **1.286 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **59.12 ns** |  **1.126 ns** |  **1.251 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **252.56 ns** |  **0.414 ns** |  **0.387 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,605.65 ns** | **14.942 ns** | **13.977 ns** | **0.0100** |     **688 B** |
