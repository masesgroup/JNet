```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **530.26 ns** |  **5.520 ns** |  **4.609 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **487.58 ns** |  **7.943 ns** |  **7.430 ns** | **0.0045** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **727.57 ns** |  **6.387 ns** |  **5.662 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,830.38 ns** | **32.455 ns** | **30.359 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **30.02 ns** |  **0.247 ns** |  **0.231 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **32.06 ns** |  **0.244 ns** |  **0.204 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **199.26 ns** |  **1.189 ns** |  **0.992 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,170.43 ns** | **20.371 ns** | **18.058 ns** | **0.0350** |     **656 B** |
