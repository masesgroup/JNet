```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 3.18GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **640.72 ns** |  **8.652 ns** |  **7.670 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **650.45 ns** | **12.352 ns** | **11.554 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **927.32 ns** | **14.686 ns** | **13.738 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,591.43 ns** | **61.804 ns** | **57.811 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **33.60 ns** |  **0.509 ns** |  **0.477 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **32.67 ns** |  **0.416 ns** |  **0.389 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **243.97 ns** |  **1.520 ns** |  **1.348 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,813.38 ns** | **68.627 ns** | **64.193 ns** | **0.0300** |     **656 B** |
