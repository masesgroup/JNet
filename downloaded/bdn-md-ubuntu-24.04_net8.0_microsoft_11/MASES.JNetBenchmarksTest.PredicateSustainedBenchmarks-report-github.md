```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **576.15 ns** |  **3.795 ns** |  **3.549 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **605.35 ns** | **11.102 ns** | **10.385 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **794.85 ns** |  **5.666 ns** |  **5.300 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,378.77 ns** | **22.907 ns** | **21.427 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **38.66 ns** |  **0.322 ns** |  **0.301 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **38.35 ns** |  **0.183 ns** |  **0.153 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **196.42 ns** |  **1.177 ns** |  **1.043 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,700.88 ns** | **14.103 ns** | **11.776 ns** | **0.0400** |     **688 B** |
