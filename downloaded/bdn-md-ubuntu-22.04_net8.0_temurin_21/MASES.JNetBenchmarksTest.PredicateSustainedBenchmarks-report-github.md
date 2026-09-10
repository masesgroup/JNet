```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.78GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **665.00 ns** | **12.146 ns** | **11.361 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **669.30 ns** | **12.998 ns** | **12.766 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **942.18 ns** | **18.214 ns** | **16.146 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,793.95 ns** | **59.005 ns** | **55.193 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **42.13 ns** |  **0.774 ns** |  **0.724 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **42.27 ns** |  **0.844 ns** |  **0.829 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **245.59 ns** |  **2.823 ns** |  **2.641 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,976.49 ns** | **77.213 ns** | **72.225 ns** | **0.0400** |     **688 B** |
