```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **645.68 ns** |  **9.588 ns** |  **8.007 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **659.64 ns** | **13.043 ns** | **14.497 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **947.83 ns** | **10.716 ns** |  **9.499 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,654.35 ns** | **74.909 ns** | **70.070 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **34.17 ns** |  **0.544 ns** |  **0.483 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **34.72 ns** |  **0.455 ns** |  **0.425 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **264.36 ns** |  **4.328 ns** |  **3.837 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,876.71 ns** | **36.554 ns** | **32.405 ns** | **0.0300** |     **656 B** |
