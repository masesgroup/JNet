```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.69GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **670.54 ns** | **13.400 ns** | **14.894 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **677.17 ns** | **12.234 ns** | **11.444 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **989.13 ns** | **18.660 ns** | **17.455 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,757.93 ns** | **73.150 ns** | **68.425 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **32.25 ns** |  **0.493 ns** |  **0.461 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **32.19 ns** |  **0.517 ns** |  **0.483 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **254.57 ns** |  **1.813 ns** |  **1.514 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,987.61 ns** | **67.378 ns** | **63.026 ns** | **0.0300** |     **656 B** |
