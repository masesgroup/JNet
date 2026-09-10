```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **584.91 ns** |  **3.457 ns** |  **3.234 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **586.69 ns** |  **3.389 ns** |  **3.170 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **780.85 ns** |  **5.469 ns** |  **5.116 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,179.78 ns** | **17.518 ns** | **16.386 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **51.91 ns** |  **0.996 ns** |  **0.979 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **49.86 ns** |  **0.974 ns** |  **0.863 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **241.76 ns** |  **0.363 ns** |  **0.322 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,774.07 ns** | **36.720 ns** | **34.348 ns** | **0.0100** |     **688 B** |
