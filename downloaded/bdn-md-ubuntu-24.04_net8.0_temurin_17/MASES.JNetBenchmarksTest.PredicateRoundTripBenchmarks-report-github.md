```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Intel Xeon 6973P-C 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               |   **571.7 ns** |  **1.92 ns** |  **1.61 ns** | **0.0010** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                |   **593.2 ns** |  **4.88 ns** |  **4.07 ns** | **0.0010** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               |   **712.5 ns** |  **4.60 ns** |  **3.85 ns** | **0.0019** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **2,598.8 ns** | **46.13 ns** | **43.15 ns** | **0.0076** |     **792 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **228.9 ns** |  **2.70 ns** |  **2.26 ns** | **0.0002** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **225.6 ns** |  **1.13 ns** |  **0.89 ns** | **0.0002** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **366.2 ns** |  **2.84 ns** |  **2.21 ns** | **0.0014** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **2,273.1 ns** |  **8.37 ns** |  **7.42 ns** | **0.0076** |     **712 B** |
