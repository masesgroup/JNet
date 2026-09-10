```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **474.92 ns** |  **6.411 ns** |  **5.997 ns** | **0.0045** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **467.74 ns** |  **6.642 ns** |  **6.213 ns** | **0.0045** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **651.69 ns** |  **5.219 ns** |  **4.627 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,579.50 ns** | **29.062 ns** | **27.185 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **33.47 ns** |  **0.405 ns** |  **0.379 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **31.31 ns** |  **0.288 ns** |  **0.270 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **186.92 ns** |  **0.786 ns** |  **0.656 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **2,867.53 ns** | **10.279 ns** |  **9.615 ns** | **0.0350** |     **656 B** |
