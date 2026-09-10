```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
INTEL XEON PLATINUM 8573C 2.99GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **569.32 ns** |  **7.031 ns** |  **6.233 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **582.82 ns** |  **5.864 ns** |  **5.485 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **826.06 ns** |  **7.050 ns** |  **6.595 ns** | **0.0017** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,854.96 ns** | **40.578 ns** | **37.956 ns** |      **-** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **55.74 ns** |  **0.757 ns** |  **0.708 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **55.70 ns** |  **0.919 ns** |  **0.859 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **230.93 ns** |  **2.435 ns** |  **2.158 ns** | **0.0009** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,233.98 ns** | **29.598 ns** | **27.686 ns** | **0.0050** |     **688 B** |
