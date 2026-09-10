```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 3.69GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **367.79 ns** |  **2.759 ns** |  **2.581 ns** | **0.0043** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **364.47 ns** |  **3.232 ns** |  **3.023 ns** | **0.0043** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **499.68 ns** |  **2.193 ns** |  **1.944 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **2,750.00 ns** | **16.674 ns** | **14.781 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **23.78 ns** |  **0.103 ns** |  **0.092 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **24.28 ns** |  **0.207 ns** |  **0.184 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **144.77 ns** |  **0.596 ns** |  **0.528 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **2,395.08 ns** | **26.674 ns** | **24.951 ns** | **0.0367** |     **656 B** |
