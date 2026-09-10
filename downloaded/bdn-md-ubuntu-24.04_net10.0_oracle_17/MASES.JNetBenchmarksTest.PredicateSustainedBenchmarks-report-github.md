```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **590.93 ns** |  **4.526 ns** |  **4.012 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **599.35 ns** |  **7.885 ns** |  **7.375 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **754.38 ns** |  **5.142 ns** |  **4.810 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,871.90 ns** | **22.508 ns** | **19.953 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **27.20 ns** |  **0.229 ns** |  **0.214 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **27.37 ns** |  **0.366 ns** |  **0.342 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **188.12 ns** |  **1.322 ns** |  **1.172 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,140.75 ns** | **15.056 ns** | **12.572 ns** | **0.0350** |     **656 B** |
