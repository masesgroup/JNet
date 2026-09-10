```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **476.70 ns** |  **4.829 ns** |  **4.517 ns** | **0.0045** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **482.78 ns** |  **4.071 ns** |  **3.609 ns** | **0.0045** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **644.77 ns** |  **5.357 ns** |  **5.011 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,600.05 ns** | **20.797 ns** | **19.453 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **30.41 ns** |  **0.143 ns** |  **0.112 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **31.61 ns** |  **0.188 ns** |  **0.176 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **186.28 ns** |  **1.469 ns** |  **1.375 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,074.25 ns** | **16.631 ns** | **13.888 ns** | **0.0350** |     **656 B** |
