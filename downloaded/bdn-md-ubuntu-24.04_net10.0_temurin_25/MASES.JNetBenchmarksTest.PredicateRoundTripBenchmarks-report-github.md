```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 3.69GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev  | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|--------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               |   **739.3 ns** |  **7.59 ns** | **7.10 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                |   **734.0 ns** |  **2.39 ns** | **2.12 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               |   **937.8 ns** |  **3.58 ns** | **3.18 ns** | **0.0114** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **3,236.4 ns** | **10.48 ns** | **9.29 ns** | **0.0420** |     **760 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **302.5 ns** |  **2.19 ns** | **2.05 ns** | **0.0014** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **303.7 ns** |  **1.46 ns** | **1.36 ns** | **0.0014** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **471.4 ns** |  **1.53 ns** | **1.28 ns** | **0.0067** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **2,739.9 ns** |  **4.08 ns** | **3.62 ns** | **0.0381** |     **680 B** |
