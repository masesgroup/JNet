```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **591.95 ns** |  **0.683 ns** |  **0.533 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **601.95 ns** |  **0.440 ns** |  **0.343 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **798.25 ns** |  **4.071 ns** |  **3.400 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,086.52 ns** | **19.213 ns** | **17.972 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **45.98 ns** |  **0.866 ns** |  **0.926 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **46.18 ns** |  **0.945 ns** |  **1.161 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **257.78 ns** |  **1.361 ns** |  **1.206 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,416.04 ns** | **21.186 ns** | **19.817 ns** |      **-** |     **656 B** |
