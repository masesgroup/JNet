```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,024.2 ns** | **13.08 ns** | **12.23 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,029.8 ns** | **11.86 ns** | **11.09 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,276.0 ns** |  **4.91 ns** |  **4.60 ns** | **0.0114** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **4,715.8 ns** | **28.34 ns** | **26.51 ns** | **0.0458** |     **792 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **444.2 ns** |  **4.78 ns** |  **4.48 ns** | **0.0014** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **447.7 ns** |  **5.37 ns** |  **5.03 ns** | **0.0014** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **652.9 ns** |  **2.63 ns** |  **2.20 ns** | **0.0067** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **4,114.8 ns** | **32.52 ns** | **30.41 ns** | **0.0381** |     **712 B** |
