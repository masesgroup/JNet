```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **513.17 ns** |  **4.099 ns** |  **3.834 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **517.62 ns** |  **3.406 ns** |  **3.186 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **704.68 ns** |  **5.344 ns** |  **4.463 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,978.47 ns** | **17.486 ns** | **15.501 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **39.84 ns** |  **0.308 ns** |  **0.257 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **39.44 ns** |  **0.436 ns** |  **0.408 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **190.15 ns** |  **0.772 ns** |  **0.684 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,406.29 ns** | **32.887 ns** | **29.153 ns** | **0.0400** |     **688 B** |
