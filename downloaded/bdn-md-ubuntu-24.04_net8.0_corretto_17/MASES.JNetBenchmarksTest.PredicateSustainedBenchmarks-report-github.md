```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **558.45 ns** |  **6.965 ns** |  **6.515 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **549.88 ns** |  **7.376 ns** |  **6.538 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **786.26 ns** |  **5.579 ns** |  **5.219 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,172.59 ns** | **27.823 ns** | **24.664 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **37.63 ns** |  **0.324 ns** |  **0.303 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **39.84 ns** |  **0.420 ns** |  **0.393 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **189.48 ns** |  **1.410 ns** |  **1.250 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,611.78 ns** | **37.787 ns** | **35.346 ns** | **0.0400** |     **688 B** |
