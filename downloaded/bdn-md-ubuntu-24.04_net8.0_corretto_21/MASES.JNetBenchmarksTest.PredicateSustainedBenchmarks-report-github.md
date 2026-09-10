```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **553.21 ns** |  **6.243 ns** |  **5.534 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **567.06 ns** |  **3.390 ns** |  **3.005 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **823.08 ns** |  **3.312 ns** |  **2.936 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,066.99 ns** | **22.371 ns** | **20.926 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **37.51 ns** |  **0.330 ns** |  **0.309 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **37.24 ns** |  **0.359 ns** |  **0.336 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **192.06 ns** |  **0.869 ns** |  **0.771 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,444.38 ns** |  **6.980 ns** |  **5.449 ns** | **0.0400** |     **688 B** |
