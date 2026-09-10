```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **545.29 ns** |  **3.028 ns** |  **2.684 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **525.29 ns** |  **7.302 ns** |  **6.473 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **716.05 ns** |  **4.851 ns** |  **4.537 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,077.22 ns** | **32.683 ns** | **28.972 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **38.58 ns** |  **0.270 ns** |  **0.253 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **39.84 ns** |  **0.307 ns** |  **0.256 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **194.88 ns** |  **2.009 ns** |  **1.781 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,441.21 ns** | **32.071 ns** | **30.000 ns** | **0.0400** |     **688 B** |
