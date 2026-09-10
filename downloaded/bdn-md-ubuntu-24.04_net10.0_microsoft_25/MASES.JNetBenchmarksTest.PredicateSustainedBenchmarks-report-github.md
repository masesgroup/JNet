```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **400.98 ns** |  **7.379 ns** |  **6.541 ns** | **0.0008** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **405.30 ns** |  **6.586 ns** |  **5.839 ns** | **0.0008** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **575.74 ns** | **10.721 ns** | **10.029 ns** | **0.0020** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **2,922.65 ns** | **40.442 ns** | **37.830 ns** | **0.0050** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **40.85 ns** |  **0.403 ns** |  **0.377 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **41.64 ns** |  **0.490 ns** |  **0.458 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **182.48 ns** |  **2.864 ns** |  **2.679 ns** | **0.0009** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **2,561.07 ns** | **50.114 ns** | **53.622 ns** | **0.0050** |     **656 B** |
