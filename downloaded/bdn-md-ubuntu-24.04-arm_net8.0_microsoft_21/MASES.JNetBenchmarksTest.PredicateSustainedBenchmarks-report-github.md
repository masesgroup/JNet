```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **593.48 ns** |  **0.614 ns** |  **0.512 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **583.77 ns** |  **0.373 ns** |  **0.291 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **778.30 ns** |  **6.266 ns** |  **5.861 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,989.55 ns** | **11.890 ns** |  **9.928 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **51.45 ns** |  **1.006 ns** |  **1.119 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **51.75 ns** |  **1.017 ns** |  **1.249 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **241.08 ns** |  **0.456 ns** |  **0.404 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,470.18 ns** | **17.843 ns** | **16.691 ns** | **0.0100** |     **688 B** |
