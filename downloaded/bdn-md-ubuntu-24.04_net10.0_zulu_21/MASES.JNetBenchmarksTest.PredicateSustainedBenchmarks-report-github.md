```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.87GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **500.77 ns** |  **3.710 ns** |  **3.470 ns** | **0.0045** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **465.07 ns** |  **6.359 ns** |  **5.637 ns** | **0.0045** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **674.69 ns** |  **4.762 ns** |  **4.454 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,508.20 ns** | **22.185 ns** | **18.525 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **31.35 ns** |  **0.259 ns** |  **0.243 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **31.16 ns** |  **0.213 ns** |  **0.199 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **187.64 ns** |  **1.414 ns** |  **1.322 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,067.63 ns** | **27.178 ns** | **22.695 ns** | **0.0350** |     **656 B** |
