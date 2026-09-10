```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **478.90 ns** |  **6.849 ns** |  **6.071 ns** | **0.0009** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **480.80 ns** |  **4.481 ns** |  **4.192 ns** | **0.0009** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **640.21 ns** |  **3.910 ns** |  **3.053 ns** | **0.0013** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,305.53 ns** | **25.259 ns** | **22.392 ns** | **0.0050** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **41.50 ns** |  **0.342 ns** |  **0.303 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **43.90 ns** |  **0.391 ns** |  **0.366 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **164.91 ns** |  **1.404 ns** |  **1.314 ns** | **0.0009** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **2,679.83 ns** | **26.314 ns** | **24.615 ns** | **0.0050** |     **656 B** |
