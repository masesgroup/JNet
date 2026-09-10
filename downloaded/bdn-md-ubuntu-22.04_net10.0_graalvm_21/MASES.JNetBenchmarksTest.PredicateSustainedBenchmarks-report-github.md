```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Intel Xeon 6973P-C 4.10GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Median      | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|------------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **421.97 ns** |  **8.252 ns** | **13.089 ns** |   **414.96 ns** | **0.0008** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **404.04 ns** |  **2.471 ns** |  **2.190 ns** |   **403.29 ns** | **0.0008** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **574.95 ns** | **10.266 ns** |  **8.572 ns** |   **572.28 ns** | **0.0011** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **2,862.15 ns** | **47.708 ns** | **44.626 ns** | **2,842.01 ns** | **0.0050** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **34.64 ns** |  **0.129 ns** |  **0.114 ns** |    **34.64 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **34.37 ns** |  **0.207 ns** |  **0.173 ns** |    **34.30 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **159.86 ns** |  **1.325 ns** |  **1.174 ns** |   **159.67 ns** | **0.0009** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **2,489.41 ns** | **48.993 ns** | **74.817 ns** | **2,496.11 ns** | **0.0050** |     **656 B** |
