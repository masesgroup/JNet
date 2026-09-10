```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.61GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **766.09 ns** | **11.986 ns** | **11.211 ns** | **0.0043** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **750.72 ns** | **14.421 ns** | **15.431 ns** | **0.0043** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               | **1,004.82 ns** | **20.066 ns** | **18.770 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,735.33 ns** | **70.304 ns** | **65.763 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **32.99 ns** |  **0.477 ns** |  **0.446 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **32.47 ns** |  **0.423 ns** |  **0.375 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **250.15 ns** |  **1.852 ns** |  **1.732 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,937.41 ns** | **42.052 ns** | **37.278 ns** | **0.0300** |     **656 B** |
