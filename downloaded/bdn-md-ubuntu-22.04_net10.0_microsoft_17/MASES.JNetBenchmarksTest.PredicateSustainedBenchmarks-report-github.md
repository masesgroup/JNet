```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 3.69GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **488.66 ns** |  **9.417 ns** |  **9.671 ns** | **0.0045** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **492.14 ns** |  **9.594 ns** |  **9.853 ns** | **0.0045** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **684.74 ns** | **11.741 ns** | **10.982 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,460.15 ns** | **55.239 ns** | **51.670 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **26.28 ns** |  **0.254 ns** |  **0.225 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **27.22 ns** |  **0.241 ns** |  **0.226 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **184.43 ns** |  **1.620 ns** |  **1.515 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **2,797.35 ns** | **28.063 ns** | **24.878 ns** | **0.0350** |     **656 B** |
