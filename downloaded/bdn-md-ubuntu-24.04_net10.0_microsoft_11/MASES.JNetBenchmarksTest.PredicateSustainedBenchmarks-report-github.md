```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **389.41 ns** |  **2.997 ns** |  **2.340 ns** | **0.0046** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **381.66 ns** |  **1.975 ns** |  **1.751 ns** | **0.0043** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **537.58 ns** |  **6.989 ns** |  **6.196 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **2,938.76 ns** | **19.222 ns** | **17.980 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **23.88 ns** |  **0.295 ns** |  **0.276 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **23.17 ns** |  **0.147 ns** |  **0.130 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **143.41 ns** |  **0.733 ns** |  **0.686 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **2,454.26 ns** | **11.217 ns** | **10.492 ns** | **0.0367** |     **656 B** |
