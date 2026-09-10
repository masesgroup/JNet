```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.46GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **605.20 ns** |  **2.641 ns** |  **2.205 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **607.67 ns** |  **4.671 ns** |  **4.369 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **805.38 ns** |  **7.107 ns** |  **6.648 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,671.74 ns** | **55.065 ns** | **51.507 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **48.31 ns** |  **0.291 ns** |  **0.227 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **45.84 ns** |  **0.407 ns** |  **0.381 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **216.53 ns** |  **0.451 ns** |  **0.400 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,873.17 ns** | **55.742 ns** | **49.414 ns** | **0.0400** |     **688 B** |
