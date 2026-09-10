```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **572.19 ns** |  **3.732 ns** |  **3.116 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **557.40 ns** |  **3.156 ns** |  **2.798 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **718.98 ns** |  **3.003 ns** |  **2.809 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,176.79 ns** | **23.268 ns** | **20.626 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **40.76 ns** |  **0.331 ns** |  **0.310 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **40.87 ns** |  **0.517 ns** |  **0.484 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **190.36 ns** |  **0.810 ns** |  **0.718 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,445.36 ns** | **21.301 ns** | **19.925 ns** | **0.0400** |     **688 B** |
