```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **577.09 ns** |  **0.654 ns** |  **0.510 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **574.56 ns** |  **1.088 ns** |  **1.018 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **792.31 ns** |  **8.082 ns** |  **7.560 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,027.84 ns** | **15.406 ns** | **14.411 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **45.69 ns** |  **0.816 ns** |  **0.724 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **44.94 ns** |  **0.657 ns** |  **0.615 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **264.29 ns** |  **0.353 ns** |  **0.330 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,200.07 ns** | **12.850 ns** | **12.020 ns** |      **-** |     **656 B** |
