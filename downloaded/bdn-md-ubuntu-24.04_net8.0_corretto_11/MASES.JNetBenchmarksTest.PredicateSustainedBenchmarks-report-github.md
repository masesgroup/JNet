```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.87GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **563.76 ns** |  **2.833 ns** |  **2.512 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **545.44 ns** |  **4.684 ns** |  **4.153 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **703.37 ns** |  **5.207 ns** |  **4.870 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,131.75 ns** | **38.399 ns** | **34.040 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **40.58 ns** |  **0.526 ns** |  **0.492 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **41.01 ns** |  **0.443 ns** |  **0.414 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **186.85 ns** |  **1.547 ns** |  **1.371 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,424.01 ns** | **18.952 ns** | **15.826 ns** | **0.0400** |     **688 B** |
