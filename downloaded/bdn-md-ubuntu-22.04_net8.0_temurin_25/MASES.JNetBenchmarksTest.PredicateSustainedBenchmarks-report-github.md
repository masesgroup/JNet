```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.63GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **674.85 ns** |  **9.664 ns** |  **9.040 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **669.27 ns** |  **9.660 ns** |  **9.036 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **925.17 ns** | **16.285 ns** | **18.101 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,923.52 ns** | **91.572 ns** | **85.657 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **43.55 ns** |  **0.517 ns** |  **0.459 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **43.03 ns** |  **0.596 ns** |  **0.557 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **246.80 ns** |  **2.366 ns** |  **2.213 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,992.60 ns** | **39.989 ns** | **33.392 ns** | **0.0400** |     **688 B** |
