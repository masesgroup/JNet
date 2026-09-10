```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 3.13GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **681.67 ns** |  **9.169 ns** |  **8.128 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **687.81 ns** | **13.513 ns** | **12.640 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **945.86 ns** | **12.978 ns** | **11.504 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,798.87 ns** | **53.289 ns** | **44.499 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **43.29 ns** |  **0.515 ns** |  **0.482 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **46.13 ns** |  **0.689 ns** |  **0.645 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **240.15 ns** |  **1.124 ns** |  **0.939 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,971.60 ns** | **46.141 ns** | **36.024 ns** | **0.0400** |     **688 B** |
