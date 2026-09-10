```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **630.20 ns** |  **0.741 ns** |  **0.657 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **634.31 ns** |  **1.381 ns** |  **1.153 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **837.37 ns** |  **9.070 ns** |  **8.484 ns** | **0.0017** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,404.07 ns** | **21.162 ns** | **19.795 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **60.58 ns** |  **0.013 ns** |  **0.011 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **60.09 ns** |  **1.151 ns** |  **1.182 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **254.56 ns** |  **0.614 ns** |  **0.575 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,739.55 ns** | **22.139 ns** | **20.709 ns** | **0.0100** |     **688 B** |
