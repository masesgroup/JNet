```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **729.52 ns** | **12.562 ns** | **11.750 ns** | **0.0043** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **713.68 ns** | **13.395 ns** | **13.755 ns** | **0.0043** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **965.15 ns** | **11.177 ns** | **10.455 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **5,019.69 ns** | **67.112 ns** | **59.493 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **43.13 ns** |  **0.681 ns** |  **0.637 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **42.45 ns** |  **0.839 ns** |  **0.861 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **242.82 ns** |  **1.324 ns** |  **1.106 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **4,127.48 ns** | **80.508 ns** | **75.307 ns** | **0.0400** |     **688 B** |
