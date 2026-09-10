```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **488.25 ns** |  **6.137 ns** |  **5.741 ns** | **0.0045** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **507.29 ns** |  **6.617 ns** |  **6.190 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **724.72 ns** |  **7.969 ns** |  **7.454 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,730.77 ns** | **33.190 ns** | **29.422 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **28.21 ns** |  **0.237 ns** |  **0.211 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **28.91 ns** |  **0.330 ns** |  **0.309 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **189.39 ns** |  **1.450 ns** |  **1.357 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,074.89 ns** | **13.815 ns** | **12.246 ns** | **0.0350** |     **656 B** |
