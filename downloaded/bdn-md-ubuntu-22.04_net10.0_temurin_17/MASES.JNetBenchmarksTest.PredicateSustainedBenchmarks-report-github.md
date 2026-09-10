```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 3.19GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **663.58 ns** |  **9.138 ns** |  **7.630 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **645.05 ns** | **11.854 ns** | **11.089 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **951.50 ns** | **13.844 ns** | **12.950 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,677.84 ns** | **75.371 ns** | **70.502 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **33.17 ns** |  **0.445 ns** |  **0.395 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **33.07 ns** |  **0.468 ns** |  **0.437 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **247.78 ns** |  **1.477 ns** |  **1.310 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,798.56 ns** | **22.004 ns** | **18.375 ns** | **0.0300** |     **656 B** |
