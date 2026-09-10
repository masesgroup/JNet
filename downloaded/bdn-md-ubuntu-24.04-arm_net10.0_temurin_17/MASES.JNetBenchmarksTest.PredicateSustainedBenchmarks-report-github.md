```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **569.82 ns** |  **0.938 ns** |  **0.783 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **573.62 ns** |  **0.919 ns** |  **0.815 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **776.19 ns** |  **2.354 ns** |  **2.087 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **5,120.23 ns** | **83.008 ns** | **77.646 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **42.94 ns** |  **0.584 ns** |  **0.517 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **43.60 ns** |  **0.799 ns** |  **0.709 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **260.90 ns** |  **0.359 ns** |  **0.318 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,505.15 ns** | **60.181 ns** | **56.294 ns** |      **-** |     **656 B** |
