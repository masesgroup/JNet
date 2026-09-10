```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 3.14GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **517.48 ns** |  **6.364 ns** |  **5.953 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **515.10 ns** |  **6.495 ns** |  **6.075 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **770.39 ns** |  **3.585 ns** |  **3.353 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,003.19 ns** | **30.493 ns** | **28.523 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **28.07 ns** |  **0.274 ns** |  **0.256 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **27.69 ns** |  **0.215 ns** |  **0.202 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **191.22 ns** |  **2.423 ns** |  **2.267 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,294.95 ns** | **26.408 ns** | **23.410 ns** | **0.0300** |     **656 B** |
