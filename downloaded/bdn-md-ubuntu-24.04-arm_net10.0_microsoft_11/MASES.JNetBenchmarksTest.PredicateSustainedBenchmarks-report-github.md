```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **609.21 ns** |  **0.327 ns** |  **0.290 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **615.18 ns** |  **0.616 ns** |  **0.481 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **821.16 ns** |  **3.002 ns** |  **2.344 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,190.72 ns** | **16.223 ns** | **13.547 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **51.47 ns** |  **0.907 ns** |  **0.848 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **50.83 ns** |  **0.788 ns** |  **0.738 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **273.39 ns** |  **0.530 ns** |  **0.496 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,500.86 ns** | **21.942 ns** | **20.525 ns** |      **-** |     **656 B** |
