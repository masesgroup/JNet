```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.70GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **681.75 ns** | **13.165 ns** | **12.930 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **658.00 ns** | **12.796 ns** | **14.736 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **931.70 ns** | **16.404 ns** | **15.344 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,757.34 ns** | **63.648 ns** | **59.537 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **33.90 ns** |  **0.477 ns** |  **0.446 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **34.72 ns** |  **0.580 ns** |  **0.570 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **251.34 ns** |  **1.448 ns** |  **1.284 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,851.30 ns** | **67.096 ns** | **62.762 ns** | **0.0300** |     **656 B** |
