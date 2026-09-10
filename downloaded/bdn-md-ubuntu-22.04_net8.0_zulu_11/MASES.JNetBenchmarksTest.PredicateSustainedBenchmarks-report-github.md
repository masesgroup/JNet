```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 3.68GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **551.99 ns** |  **8.635 ns** |  **8.078 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **547.22 ns** |  **4.889 ns** |  **4.573 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **720.08 ns** | **14.154 ns** | **15.732 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,800.57 ns** | **40.307 ns** | **37.704 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **36.49 ns** |  **0.339 ns** |  **0.317 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **35.99 ns** |  **0.386 ns** |  **0.361 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **189.05 ns** |  **2.040 ns** |  **1.908 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,096.93 ns** | **36.205 ns** | **32.095 ns** | **0.0400** |     **688 B** |
