```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 9V45 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               |   **595.6 ns** |  **4.07 ns** |  **3.81 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                |   **582.9 ns** |  **4.08 ns** |  **3.19 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               |   **749.1 ns** |  **6.29 ns** |  **5.89 ns** | **0.0114** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **2,542.2 ns** | **27.84 ns** | **21.74 ns** | **0.0420** |     **760 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **195.6 ns** |  **2.45 ns** |  **2.04 ns** | **0.0014** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **211.8 ns** |  **1.24 ns** |  **1.16 ns** | **0.0014** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **365.8 ns** |  **2.60 ns** |  **2.03 ns** | **0.0072** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **2,187.0 ns** | **15.10 ns** | **13.39 ns** | **0.0381** |     **680 B** |
