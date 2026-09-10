```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Intel Xeon 6973P-C 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **393.39 ns** |  **4.366 ns** |  **3.409 ns** | **0.0008** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **394.85 ns** |  **2.912 ns** |  **2.432 ns** | **0.0008** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **535.81 ns** |  **7.422 ns** |  **5.795 ns** | **0.0020** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **2,579.26 ns** | **18.899 ns** | **15.782 ns** | **0.0050** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **37.88 ns** |  **0.568 ns** |  **0.503 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **38.53 ns** |  **0.586 ns** |  **0.761 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **145.85 ns** |  **2.416 ns** |  **3.387 ns** | **0.0011** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **2,201.45 ns** | **13.868 ns** | **10.827 ns** | **0.0067** |     **688 B** |
