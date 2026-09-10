```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **616.96 ns** |  **0.771 ns** |  **0.644 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **601.00 ns** |  **2.292 ns** |  **2.144 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **823.67 ns** |  **6.662 ns** |  **6.231 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,939.70 ns** | **45.668 ns** | **42.718 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **43.38 ns** |  **0.773 ns** |  **0.723 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **43.37 ns** |  **0.529 ns** |  **0.469 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **263.89 ns** |  **0.392 ns** |  **0.367 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **4,146.65 ns** | **45.297 ns** | **42.371 ns** |      **-** |     **656 B** |
