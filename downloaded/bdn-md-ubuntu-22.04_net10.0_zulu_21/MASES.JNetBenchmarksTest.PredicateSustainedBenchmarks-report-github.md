```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.85GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **609.19 ns** |  **9.509 ns** |  **8.429 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **617.15 ns** | **12.182 ns** | **14.029 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **849.39 ns** | **15.838 ns** | **15.555 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,534.99 ns** | **56.350 ns** | **49.953 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **37.85 ns** |  **0.543 ns** |  **0.508 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **35.33 ns** |  **0.430 ns** |  **0.402 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **247.58 ns** |  **2.839 ns** |  **2.516 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,570.48 ns** | **46.481 ns** | **43.478 ns** | **0.0300** |     **656 B** |
