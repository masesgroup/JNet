```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **517.41 ns** |  **3.040 ns** |  **2.844 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **500.95 ns** |  **4.568 ns** |  **4.273 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **715.40 ns** |  **5.746 ns** |  **5.375 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,825.21 ns** | **33.590 ns** | **29.777 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **34.01 ns** |  **0.264 ns** |  **0.247 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **28.03 ns** |  **0.196 ns** |  **0.184 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **188.73 ns** |  **1.480 ns** |  **1.312 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,162.27 ns** | **10.159 ns** |  **8.483 ns** | **0.0350** |     **656 B** |
