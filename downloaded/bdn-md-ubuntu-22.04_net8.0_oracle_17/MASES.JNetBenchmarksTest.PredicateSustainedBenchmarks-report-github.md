```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
INTEL XEON PLATINUM 8573C 3.50GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **564.49 ns** |  **7.765 ns** |  **6.883 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **556.86 ns** |  **4.996 ns** |  **4.673 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **807.61 ns** |  **6.992 ns** |  **6.198 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,712.14 ns** | **31.869 ns** | **28.251 ns** |      **-** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **50.62 ns** |  **1.010 ns** |  **1.542 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **51.42 ns** |  **0.293 ns** |  **0.260 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **206.43 ns** |  **1.563 ns** |  **1.462 ns** | **0.0009** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **2,938.88 ns** | **22.871 ns** | **21.393 ns** | **0.0050** |     **688 B** |
