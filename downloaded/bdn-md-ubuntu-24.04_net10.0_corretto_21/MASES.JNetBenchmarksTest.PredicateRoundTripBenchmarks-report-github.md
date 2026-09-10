```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 9V45 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               |   **596.5 ns** |  **7.76 ns** |  **6.48 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                |   **626.9 ns** |  **4.55 ns** |  **3.80 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               |   **730.1 ns** |  **6.59 ns** |  **5.14 ns** | **0.0114** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **2,502.0 ns** | **26.53 ns** | **20.71 ns** | **0.0420** |     **760 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **212.7 ns** |  **1.84 ns** |  **1.72 ns** | **0.0014** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **203.7 ns** |  **2.79 ns** |  **2.61 ns** | **0.0014** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **353.0 ns** |  **4.33 ns** |  **3.84 ns** | **0.0072** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **2,139.0 ns** | **33.30 ns** | **27.81 ns** | **0.0381** |     **680 B** |
