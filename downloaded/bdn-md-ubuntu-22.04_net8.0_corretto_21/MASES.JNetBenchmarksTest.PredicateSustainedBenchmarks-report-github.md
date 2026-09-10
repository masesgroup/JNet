```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.59GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **734.48 ns** | **14.333 ns** | **15.336 ns** | **0.0043** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **727.26 ns** | **12.800 ns** | **10.688 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **957.57 ns** | **15.107 ns** | **14.131 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **5,009.32 ns** | **74.138 ns** | **65.721 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **42.73 ns** |  **0.844 ns** |  **0.972 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **42.24 ns** |  **0.647 ns** |  **0.605 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **236.50 ns** |  **1.310 ns** |  **1.094 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **4,076.13 ns** | **72.171 ns** | **67.509 ns** | **0.0400** |     **688 B** |
