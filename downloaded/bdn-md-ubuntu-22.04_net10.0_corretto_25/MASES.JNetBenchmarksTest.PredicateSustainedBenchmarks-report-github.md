```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.63GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **663.08 ns** | **13.043 ns** | **13.394 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **678.83 ns** | **13.380 ns** | **17.398 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **938.94 ns** | **18.003 ns** | **16.840 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,696.90 ns** | **57.457 ns** | **53.746 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **34.60 ns** |  **0.276 ns** |  **0.230 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **34.31 ns** |  **0.251 ns** |  **0.235 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **250.92 ns** |  **3.322 ns** |  **2.945 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,894.51 ns** | **75.736 ns** | **74.383 ns** | **0.0300** |     **656 B** |
