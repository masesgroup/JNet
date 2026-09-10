```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.92GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **488.88 ns** |  **5.355 ns** |  **4.747 ns** | **0.0045** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **506.45 ns** |  **5.199 ns** |  **4.342 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **706.54 ns** |  **2.249 ns** |  **1.878 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,805.32 ns** | **22.821 ns** | **19.057 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **28.50 ns** |  **0.218 ns** |  **0.204 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **27.55 ns** |  **0.165 ns** |  **0.147 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **190.76 ns** |  **0.831 ns** |  **0.778 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,141.64 ns** | **19.379 ns** | **18.127 ns** | **0.0350** |     **656 B** |
