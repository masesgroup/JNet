```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 9V45 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **274.06 ns** |  **2.084 ns** |  **1.848 ns** | **0.0047** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **275.36 ns** |  **2.982 ns** |  **2.644 ns** | **0.0047** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **397.48 ns** |  **7.075 ns** |  **5.523 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **2,218.03 ns** | **25.338 ns** | **19.783 ns** | **0.0433** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **31.23 ns** |  **0.295 ns** |  **0.247 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **31.24 ns** |  **0.136 ns** |  **0.121 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **130.61 ns** |  **2.187 ns** |  **2.045 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **1,853.21 ns** | **22.357 ns** | **18.669 ns** | **0.0367** |     **656 B** |
