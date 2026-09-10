```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Intel Xeon 6973P-C 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Median      | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|------------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **341.45 ns** |  **3.041 ns** |  **2.696 ns** |   **341.25 ns** | **0.0007** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **351.31 ns** |  **6.637 ns** | **13.557 ns** |   **345.01 ns** | **0.0007** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **487.57 ns** |  **4.898 ns** |  **4.090 ns** |   **486.64 ns** | **0.0018** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **2,442.90 ns** | **28.311 ns** | **23.641 ns** | **2,435.77 ns** | **0.0067** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **37.95 ns** |  **0.401 ns** |  **0.335 ns** |    **37.94 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **38.07 ns** |  **0.695 ns** |  **0.580 ns** |    **37.94 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **146.50 ns** |  **2.593 ns** |  **2.426 ns** |   **145.61 ns** | **0.0011** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **2,005.12 ns** | **22.172 ns** | **17.311 ns** | **2,001.63 ns** | **0.0067** |     **688 B** |
