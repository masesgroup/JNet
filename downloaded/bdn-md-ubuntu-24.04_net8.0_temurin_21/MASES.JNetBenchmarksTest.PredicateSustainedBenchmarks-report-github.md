```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **746.67 ns** |  **4.429 ns** |  **3.698 ns** | **0.0043** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **524.61 ns** |  **4.339 ns** |  **3.624 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **730.61 ns** |  **6.583 ns** |  **6.157 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,994.96 ns** | **24.196 ns** | **21.449 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **37.60 ns** |  **0.421 ns** |  **0.373 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **38.39 ns** |  **0.767 ns** |  **0.753 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **195.54 ns** |  **3.765 ns** |  **3.521 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,362.21 ns** | **18.351 ns** | **16.268 ns** | **0.0400** |     **688 B** |
