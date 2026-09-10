```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **533.69 ns** |  **2.625 ns** |  **2.327 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **497.87 ns** |  **4.088 ns** |  **3.624 ns** | **0.0045** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **668.41 ns** |  **3.611 ns** |  **3.201 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,794.09 ns** | **20.012 ns** | **17.740 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **46.00 ns** |  **0.891 ns** |  **1.438 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **40.84 ns** |  **0.369 ns** |  **0.345 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **187.11 ns** |  **0.771 ns** |  **0.684 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,235.14 ns** | **16.982 ns** | **15.054 ns** | **0.0400** |     **688 B** |
