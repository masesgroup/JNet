```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 9V45 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **277.21 ns** |  **2.214 ns** |  **2.071 ns** | **0.0047** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **279.52 ns** |  **4.568 ns** |  **4.691 ns** | **0.0047** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **393.04 ns** |  **3.391 ns** |  **3.172 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **2,208.17 ns** | **29.989 ns** | **25.042 ns** | **0.0433** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **30.94 ns** |  **0.293 ns** |  **0.245 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **30.59 ns** |  **0.264 ns** |  **0.206 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **130.14 ns** |  **2.184 ns** |  **1.936 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **1,803.52 ns** | **24.869 ns** | **20.767 ns** | **0.0367** |     **656 B** |
