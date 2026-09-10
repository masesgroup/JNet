```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.88GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **520.37 ns** |  **5.314 ns** |  **4.970 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **536.72 ns** |  **6.307 ns** |  **5.899 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **722.15 ns** |  **6.502 ns** |  **5.764 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,990.22 ns** | **31.242 ns** | **29.224 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **37.40 ns** |  **0.431 ns** |  **0.403 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **38.99 ns** |  **0.250 ns** |  **0.221 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **213.00 ns** |  **1.287 ns** |  **1.203 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,330.70 ns** | **15.388 ns** | **14.394 ns** | **0.0400** |     **688 B** |
