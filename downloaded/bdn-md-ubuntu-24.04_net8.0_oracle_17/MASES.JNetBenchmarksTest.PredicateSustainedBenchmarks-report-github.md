```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **579.77 ns** |  **7.957 ns** |  **7.054 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **569.37 ns** |  **6.252 ns** |  **5.542 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **759.86 ns** |  **3.538 ns** |  **3.309 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,216.55 ns** | **23.939 ns** | **19.990 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **37.82 ns** |  **0.261 ns** |  **0.244 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **37.13 ns** |  **0.511 ns** |  **0.478 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **191.39 ns** |  **1.013 ns** |  **0.898 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,406.47 ns** | **26.320 ns** | **23.332 ns** | **0.0400** |     **688 B** |
