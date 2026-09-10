```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.58GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **711.67 ns** | **13.013 ns** | **12.172 ns** | **0.0043** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **712.54 ns** | **13.361 ns** | **12.498 ns** | **0.0043** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               | **1,014.39 ns** | **13.805 ns** | **12.238 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,947.65 ns** | **68.284 ns** | **63.873 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **34.21 ns** |  **0.445 ns** |  **0.416 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **33.31 ns** |  **0.453 ns** |  **0.424 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **250.75 ns** |  **1.656 ns** |  **1.468 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **4,094.78 ns** | **60.485 ns** | **56.577 ns** | **0.0300** |     **656 B** |
