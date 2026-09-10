```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V45 4.52GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **376.01 ns** |  **5.200 ns** |  **4.610 ns** | **0.0043** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **360.45 ns** |  **7.051 ns** |  **5.888 ns** | **0.0043** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **505.48 ns** |  **9.001 ns** |  **7.979 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **2,659.12 ns** | **50.656 ns** | **49.751 ns** | **0.0450** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **34.31 ns** |  **0.681 ns** |  **0.729 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **34.42 ns** |  **0.356 ns** |  **0.316 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **149.28 ns** |  **2.600 ns** |  **2.305 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **2,249.43 ns** | **43.307 ns** | **48.136 ns** | **0.0400** |     **688 B** |
