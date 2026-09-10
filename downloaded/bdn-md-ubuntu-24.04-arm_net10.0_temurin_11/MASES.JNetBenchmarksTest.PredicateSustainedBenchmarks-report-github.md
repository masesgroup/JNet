```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **621.05 ns** |  **0.875 ns** |  **0.775 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **623.48 ns** |  **2.313 ns** |  **2.163 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **840.98 ns** |  **3.626 ns** |  **3.392 ns** | **0.0017** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,337.82 ns** | **13.558 ns** | **12.682 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **50.47 ns** |  **0.473 ns** |  **0.443 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **50.73 ns** |  **0.881 ns** |  **0.824 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **273.47 ns** |  **0.459 ns** |  **0.429 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,662.75 ns** | **36.710 ns** | **32.542 ns** |      **-** |     **656 B** |
