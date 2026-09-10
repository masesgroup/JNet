```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **412.84 ns** |  **5.810 ns** |  **5.434 ns** | **0.0008** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **405.45 ns** |  **3.918 ns** |  **3.473 ns** | **0.0008** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **555.35 ns** |  **5.282 ns** |  **4.940 ns** | **0.0011** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **2,886.66 ns** | **29.044 ns** | **25.747 ns** | **0.0050** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **41.56 ns** |  **0.272 ns** |  **0.241 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **42.12 ns** |  **0.305 ns** |  **0.238 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **167.77 ns** |  **1.988 ns** |  **1.860 ns** | **0.0009** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **2,469.07 ns** | **36.273 ns** | **33.929 ns** | **0.0067** |     **656 B** |
