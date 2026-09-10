```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **471.62 ns** |  **5.520 ns** |  **5.163 ns** | **0.0045** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **493.29 ns** |  **5.372 ns** |  **5.025 ns** | **0.0045** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **686.27 ns** |  **6.081 ns** |  **5.390 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,762.09 ns** | **25.252 ns** | **21.087 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **27.65 ns** |  **0.294 ns** |  **0.275 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **28.87 ns** |  **0.268 ns** |  **0.237 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **189.86 ns** |  **1.391 ns** |  **1.301 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,148.74 ns** | **13.846 ns** | **12.952 ns** | **0.0350** |     **656 B** |
