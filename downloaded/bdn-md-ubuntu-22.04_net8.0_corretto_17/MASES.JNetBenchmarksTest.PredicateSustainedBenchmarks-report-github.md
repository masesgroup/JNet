```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
INTEL XEON PLATINUM 8573C 2.96GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **610.23 ns** |  **4.508 ns** |  **4.217 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **615.70 ns** |  **8.773 ns** |  **7.777 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **860.21 ns** |  **6.563 ns** |  **5.818 ns** | **0.0017** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,896.24 ns** | **33.954 ns** | **31.760 ns** |      **-** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **58.16 ns** |  **0.344 ns** |  **0.322 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **57.52 ns** |  **1.129 ns** |  **2.092 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **229.70 ns** |  **1.140 ns** |  **1.067 ns** | **0.0009** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,225.25 ns** | **15.841 ns** | **14.817 ns** | **0.0050** |     **688 B** |
