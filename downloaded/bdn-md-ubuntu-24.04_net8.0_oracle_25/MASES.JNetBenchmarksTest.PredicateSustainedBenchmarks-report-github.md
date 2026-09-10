```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **525.15 ns** |  **6.490 ns** |  **6.071 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **536.01 ns** |  **5.924 ns** |  **4.625 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **722.87 ns** |  **2.759 ns** |  **2.304 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,025.64 ns** | **24.208 ns** | **21.460 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **38.70 ns** |  **0.223 ns** |  **0.209 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **39.84 ns** |  **0.579 ns** |  **0.513 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **198.51 ns** |  **1.083 ns** |  **0.905 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,432.65 ns** | **22.739 ns** | **20.158 ns** | **0.0400** |     **688 B** |
