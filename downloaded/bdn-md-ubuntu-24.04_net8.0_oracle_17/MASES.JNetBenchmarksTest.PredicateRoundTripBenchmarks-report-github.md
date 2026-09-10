```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,151.5 ns** |  **9.99 ns** |  **9.34 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,066.8 ns** | **11.73 ns** |  **9.79 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,406.3 ns** |  **4.91 ns** |  **4.36 ns** | **0.0114** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **4,710.9 ns** | **18.71 ns** | **16.59 ns** | **0.0458** |     **792 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **429.6 ns** |  **2.88 ns** |  **2.70 ns** | **0.0014** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **430.8 ns** |  **5.18 ns** |  **4.84 ns** | **0.0014** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **639.4 ns** |  **3.43 ns** |  **3.21 ns** | **0.0067** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **3,982.5 ns** | **13.50 ns** | **11.28 ns** | **0.0381** |     **712 B** |
