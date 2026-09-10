```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
INTEL XEON PLATINUM 8573C 3.04GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **580.47 ns** |  **3.983 ns** |  **3.531 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **578.98 ns** |  **7.347 ns** |  **6.872 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **798.05 ns** |  **7.642 ns** |  **7.148 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,191.82 ns** | **76.645 ns** | **71.693 ns** |      **-** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **49.98 ns** |  **0.324 ns** |  **0.287 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **49.26 ns** |  **0.972 ns** |  **1.597 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **229.09 ns** |  **0.827 ns** |  **0.734 ns** | **0.0009** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,427.07 ns** | **67.860 ns** | **69.687 ns** |      **-** |     **656 B** |
