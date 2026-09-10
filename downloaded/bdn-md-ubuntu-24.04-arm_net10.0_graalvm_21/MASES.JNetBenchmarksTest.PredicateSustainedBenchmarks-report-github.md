```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **588.52 ns** |  **0.533 ns** |  **0.416 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **599.32 ns** |  **1.554 ns** |  **1.453 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **784.90 ns** |  **2.007 ns** |  **1.567 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,091.22 ns** | **17.052 ns** | **15.950 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **44.74 ns** |  **0.872 ns** |  **1.071 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **44.94 ns** |  **0.839 ns** |  **0.861 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **255.22 ns** |  **0.508 ns** |  **0.476 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,467.03 ns** | **26.026 ns** | **24.344 ns** |      **-** |     **656 B** |
