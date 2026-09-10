```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **517.75 ns** |  **5.225 ns** |  **4.632 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **501.60 ns** |  **2.723 ns** |  **2.414 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **677.73 ns** |  **2.560 ns** |  **2.138 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,944.11 ns** | **26.381 ns** | **22.029 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **41.25 ns** |  **0.358 ns** |  **0.318 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **42.11 ns** |  **0.486 ns** |  **0.454 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **186.75 ns** |  **0.972 ns** |  **0.862 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,382.30 ns** | **12.823 ns** | **10.708 ns** | **0.0400** |     **688 B** |
