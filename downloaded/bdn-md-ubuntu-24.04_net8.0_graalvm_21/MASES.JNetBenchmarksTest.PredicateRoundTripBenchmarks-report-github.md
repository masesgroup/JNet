```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Intel Xeon 6973P-C 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Median     | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-----------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               |   **643.0 ns** |  **3.40 ns** |  **3.18 ns** |   **643.8 ns** | **0.0010** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                |   **593.9 ns** | **11.79 ns** | **24.87 ns** |   **579.8 ns** | **0.0010** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               |   **765.3 ns** | **15.05 ns** | **30.74 ns** |   **748.8 ns** | **0.0019** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **2,583.6 ns** | **10.25 ns** |  **9.59 ns** | **2,581.0 ns** | **0.0076** |     **792 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **227.4 ns** |  **2.20 ns** |  **1.95 ns** |   **227.7 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **229.5 ns** |  **2.52 ns** |  **2.10 ns** |   **229.4 ns** | **0.0002** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **382.2 ns** |  **7.15 ns** |  **7.34 ns** |   **378.8 ns** | **0.0014** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **2,289.5 ns** | **35.78 ns** | **36.74 ns** | **2,279.0 ns** | **0.0076** |     **712 B** |
