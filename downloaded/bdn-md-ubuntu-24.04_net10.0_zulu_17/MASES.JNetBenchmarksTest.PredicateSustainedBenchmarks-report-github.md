```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **502.37 ns** |  **6.409 ns** |  **5.995 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **497.48 ns** |  **7.602 ns** |  **7.110 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **684.38 ns** |  **7.033 ns** |  **6.579 ns** | **0.0013** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,475.74 ns** | **66.452 ns** | **68.241 ns** |      **-** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **49.51 ns** |  **0.976 ns** |  **1.950 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **49.51 ns** |  **0.967 ns** |  **1.476 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **200.76 ns** |  **1.227 ns** |  **1.088 ns** | **0.0009** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **2,922.47 ns** | **35.769 ns** | **33.458 ns** | **0.0050** |     **656 B** |
