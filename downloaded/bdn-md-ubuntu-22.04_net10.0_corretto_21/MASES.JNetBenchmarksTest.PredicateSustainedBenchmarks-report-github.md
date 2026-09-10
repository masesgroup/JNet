```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Intel Xeon Platinum 8370C CPU 2.80GHz (Max: 3.33GHz), 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **652.42 ns** |  **5.425 ns** |  **4.809 ns** | **0.0025** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **664.27 ns** | **10.919 ns** | **10.213 ns** | **0.0025** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               | **1,102.00 ns** |  **8.461 ns** |  **7.914 ns** | **0.0060** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,719.62 ns** | **20.837 ns** | **19.491 ns** | **0.0200** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **49.59 ns** |  **0.409 ns** |  **0.383 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **50.30 ns** |  **0.551 ns** |  **0.515 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **279.55 ns** |  **1.352 ns** |  **1.199 ns** | **0.0038** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,846.44 ns** | **46.913 ns** | **41.587 ns** | **0.0200** |     **656 B** |
