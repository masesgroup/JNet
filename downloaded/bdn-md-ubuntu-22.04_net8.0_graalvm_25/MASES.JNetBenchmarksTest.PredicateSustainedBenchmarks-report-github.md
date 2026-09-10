```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.87GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **715.41 ns** | **13.266 ns** | **13.029 ns** | **0.0043** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **677.06 ns** |  **7.443 ns** |  **6.598 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **917.94 ns** | **10.879 ns** | **10.176 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,689.21 ns** | **54.045 ns** | **50.554 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **47.30 ns** |  **0.472 ns** |  **0.394 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **46.58 ns** |  **0.710 ns** |  **0.664 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **240.28 ns** |  **3.353 ns** |  **3.136 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,942.65 ns** | **65.070 ns** | **60.867 ns** | **0.0400** |     **688 B** |
