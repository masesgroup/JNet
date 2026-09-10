```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **391.34 ns** |  **2.592 ns** |  **2.424 ns** | **0.0046** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **387.00 ns** |  **2.316 ns** |  **2.167 ns** | **0.0046** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **524.07 ns** |  **2.235 ns** |  **1.981 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,029.22 ns** | **23.365 ns** | **21.855 ns** | **0.0450** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **31.44 ns** |  **0.206 ns** |  **0.193 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **31.81 ns** |  **0.224 ns** |  **0.210 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **145.74 ns** |  **1.077 ns** |  **1.007 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **2,545.97 ns** | **16.591 ns** | **14.708 ns** | **0.0400** |     **688 B** |
