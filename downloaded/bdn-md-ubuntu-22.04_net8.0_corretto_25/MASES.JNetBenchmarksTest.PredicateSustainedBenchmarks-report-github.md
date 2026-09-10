```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.87GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **680.03 ns** | **11.277 ns** | **10.548 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **679.67 ns** | **12.962 ns** | **13.311 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **913.14 ns** | **10.779 ns** |  **9.556 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,791.58 ns** | **33.314 ns** | **29.532 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **46.23 ns** |  **0.630 ns** |  **0.558 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **48.01 ns** |  **0.726 ns** |  **0.680 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **245.26 ns** |  **3.369 ns** |  **2.986 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,978.61 ns** | **57.084 ns** | **53.396 ns** | **0.0400** |     **688 B** |
