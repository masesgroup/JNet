```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 3.69GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **465.68 ns** |  **5.725 ns** |  **5.075 ns** | **0.0045** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **474.55 ns** |  **8.363 ns** |  **7.823 ns** | **0.0045** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **668.49 ns** | **11.613 ns** | **10.863 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,323.28 ns** | **48.473 ns** | **45.342 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **27.79 ns** |  **0.355 ns** |  **0.332 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **27.52 ns** |  **0.197 ns** |  **0.175 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **185.84 ns** |  **1.512 ns** |  **1.340 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **2,727.79 ns** | **35.238 ns** | **32.962 ns** | **0.0350** |     **656 B** |
