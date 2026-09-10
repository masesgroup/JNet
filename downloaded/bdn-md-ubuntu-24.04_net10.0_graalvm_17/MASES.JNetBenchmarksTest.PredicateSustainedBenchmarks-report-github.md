```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **509.52 ns** |  **6.143 ns** |  **5.445 ns** | **0.0040** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **476.84 ns** |  **6.277 ns** |  **5.871 ns** | **0.0045** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **721.34 ns** | **11.522 ns** | **10.778 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,800.00 ns** | **20.567 ns** | **18.232 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **28.78 ns** |  **0.254 ns** |  **0.237 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **30.91 ns** |  **0.377 ns** |  **0.352 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **192.45 ns** |  **0.774 ns** |  **0.646 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,130.07 ns** | **13.335 ns** | **11.821 ns** | **0.0350** |     **656 B** |
