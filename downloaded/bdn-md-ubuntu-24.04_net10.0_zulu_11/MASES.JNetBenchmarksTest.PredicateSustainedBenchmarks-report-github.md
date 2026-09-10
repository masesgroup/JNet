```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **464.06 ns** |  **5.164 ns** |  **4.831 ns** | **0.0009** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **460.86 ns** |  **3.411 ns** |  **3.191 ns** | **0.0009** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **605.46 ns** |  **2.608 ns** |  **2.312 ns** | **0.0011** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,210.55 ns** | **20.313 ns** | **18.007 ns** | **0.0050** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **41.14 ns** |  **0.189 ns** |  **0.177 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **43.00 ns** |  **0.253 ns** |  **0.236 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **169.31 ns** |  **0.550 ns** |  **0.487 ns** | **0.0009** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **2,697.94 ns** | **22.532 ns** | **21.076 ns** | **0.0050** |     **656 B** |
