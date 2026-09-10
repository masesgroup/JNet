```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **533.41 ns** |  **6.519 ns** |  **6.098 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **558.87 ns** |  **7.076 ns** |  **6.619 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **772.31 ns** |  **4.745 ns** |  **4.438 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,148.26 ns** | **14.972 ns** | **11.689 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **31.12 ns** |  **0.247 ns** |  **0.219 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **30.47 ns** |  **0.182 ns** |  **0.171 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **204.12 ns** |  **1.137 ns** |  **0.888 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,395.33 ns** | **35.159 ns** | **31.168 ns** | **0.0300** |     **656 B** |
