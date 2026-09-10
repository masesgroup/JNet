```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               |   **969.0 ns** | **11.38 ns** | **10.64 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                |   **980.9 ns** | **13.12 ns** | **11.63 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,260.4 ns** |  **6.89 ns** |  **6.11 ns** | **0.0114** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **4,233.2 ns** | **37.11 ns** | **32.89 ns** | **0.0381** |     **760 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **403.5 ns** |  **4.55 ns** |  **4.26 ns** | **0.0014** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **399.8 ns** |  **5.70 ns** |  **5.33 ns** | **0.0014** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **626.3 ns** |  **2.48 ns** |  **2.20 ns** | **0.0067** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **3,595.2 ns** | **16.64 ns** | **13.89 ns** | **0.0381** |     **680 B** |
