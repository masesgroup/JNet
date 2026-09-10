```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **712.75 ns** | **11.062 ns** | **10.347 ns** | **0.0043** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **710.05 ns** | **14.083 ns** | **13.832 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               | **1,066.88 ns** | **20.672 ns** | **19.336 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,900.84 ns** | **66.463 ns** | **62.170 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **33.40 ns** |  **0.434 ns** |  **0.406 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **33.31 ns** |  **0.301 ns** |  **0.251 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **245.25 ns** |  **3.097 ns** |  **2.745 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,946.77 ns** | **29.383 ns** | **24.536 ns** | **0.0300** |     **656 B** |
