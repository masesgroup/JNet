```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **599.62 ns** |  **0.582 ns** |  **0.455 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **595.10 ns** |  **5.276 ns** |  **4.936 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **811.68 ns** |  **5.696 ns** |  **5.328 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,348.51 ns** | **41.586 ns** | **40.843 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **45.43 ns** |  **0.020 ns** |  **0.019 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **45.47 ns** |  **0.895 ns** |  **1.420 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **251.59 ns** |  **0.352 ns** |  **0.329 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,552.96 ns** | **29.167 ns** | **28.646 ns** |      **-** |     **656 B** |
