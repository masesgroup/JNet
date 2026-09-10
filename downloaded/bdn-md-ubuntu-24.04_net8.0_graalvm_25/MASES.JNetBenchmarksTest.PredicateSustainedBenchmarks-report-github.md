```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **552.53 ns** |  **6.997 ns** |  **6.545 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **553.17 ns** |  **6.354 ns** |  **5.633 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **732.71 ns** |  **1.924 ns** |  **1.502 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,038.77 ns** | **32.052 ns** | **28.413 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **42.28 ns** |  **0.771 ns** |  **0.644 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **38.49 ns** |  **0.320 ns** |  **0.299 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **190.96 ns** |  **1.282 ns** |  **1.137 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,416.87 ns** | **20.469 ns** | **18.145 ns** | **0.0400** |     **688 B** |
