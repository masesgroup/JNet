```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.59GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **665.81 ns** |  **7.312 ns** |  **6.482 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **700.79 ns** |  **9.581 ns** |  **8.962 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **973.33 ns** | **13.968 ns** | **12.382 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,770.24 ns** | **50.823 ns** | **47.540 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **33.29 ns** |  **0.456 ns** |  **0.426 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **32.83 ns** |  **0.374 ns** |  **0.350 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **248.92 ns** |  **1.715 ns** |  **1.520 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,950.58 ns** | **75.288 ns** | **73.943 ns** | **0.0300** |     **656 B** |
