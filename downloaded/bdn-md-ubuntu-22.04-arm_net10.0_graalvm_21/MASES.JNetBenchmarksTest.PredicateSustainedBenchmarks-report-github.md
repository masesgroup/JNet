```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **584.74 ns** |  **0.608 ns** |  **0.507 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **579.52 ns** |  **0.620 ns** |  **0.550 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **792.09 ns** |  **7.974 ns** |  **7.459 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,193.83 ns** | **20.386 ns** | **19.069 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **44.41 ns** |  **0.876 ns** |  **0.860 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **44.25 ns** |  **0.876 ns** |  **1.108 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **259.08 ns** |  **0.509 ns** |  **0.451 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,417.53 ns** | **21.509 ns** | **20.119 ns** |      **-** |     **656 B** |
