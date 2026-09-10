```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.86GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **674.22 ns** | **12.832 ns** | **12.603 ns** | **0.0043** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **676.76 ns** | **12.834 ns** | **12.604 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **938.02 ns** | **12.249 ns** | **10.859 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,656.30 ns** | **76.872 ns** | **71.906 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **35.52 ns** |  **0.516 ns** |  **0.483 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **35.32 ns** |  **0.367 ns** |  **0.343 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **240.78 ns** |  **2.787 ns** |  **2.607 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,824.80 ns** | **66.514 ns** | **62.217 ns** | **0.0300** |     **656 B** |
