```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 3.69GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **519.52 ns** |  **6.170 ns** |  **5.771 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **523.79 ns** |  **9.192 ns** |  **8.598 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **699.77 ns** |  **6.834 ns** |  **6.058 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,669.90 ns** | **56.839 ns** | **53.168 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **35.94 ns** |  **0.490 ns** |  **0.458 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **35.96 ns** |  **0.464 ns** |  **0.434 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **189.63 ns** |  **3.015 ns** |  **2.820 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,056.16 ns** | **43.306 ns** | **40.509 ns** | **0.0400** |     **688 B** |
