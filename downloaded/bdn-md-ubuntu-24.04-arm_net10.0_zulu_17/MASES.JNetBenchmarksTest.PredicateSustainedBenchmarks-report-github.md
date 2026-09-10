```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **611.40 ns** |  **1.171 ns** |  **0.914 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **613.92 ns** |  **2.953 ns** |  **2.763 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **815.61 ns** |  **4.848 ns** |  **4.535 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,936.83 ns** | **67.396 ns** | **63.042 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **42.96 ns** |  **0.392 ns** |  **0.328 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **43.74 ns** |  **0.319 ns** |  **0.298 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **261.09 ns** |  **0.457 ns** |  **0.357 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **4,052.77 ns** | **23.002 ns** | **19.208 ns** |      **-** |     **656 B** |
