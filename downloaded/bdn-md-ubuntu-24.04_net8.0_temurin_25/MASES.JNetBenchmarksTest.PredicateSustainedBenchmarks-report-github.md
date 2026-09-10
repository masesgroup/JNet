```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **413.94 ns** |  **5.032 ns** |  **4.202 ns** | **0.0008** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **413.14 ns** |  **6.892 ns** |  **7.374 ns** | **0.0008** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **573.63 ns** |  **8.272 ns** |  **7.333 ns** | **0.0011** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **2,895.48 ns** | **50.948 ns** | **58.672 ns** | **0.0050** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **45.39 ns** |  **0.890 ns** |  **1.671 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **45.05 ns** |  **0.886 ns** |  **1.480 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **173.69 ns** |  **2.382 ns** |  **1.989 ns** | **0.0009** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **2,388.86 ns** | **25.135 ns** | **22.282 ns** | **0.0067** |     **688 B** |
