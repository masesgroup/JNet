```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 3.18GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,281.7 ns** | **24.74 ns** | **24.30 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,243.4 ns** | **22.83 ns** | **20.24 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,597.2 ns** | **18.83 ns** | **17.61 ns** | **0.0114** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **5,238.2 ns** | **45.46 ns** | **37.96 ns** | **0.0381** |     **760 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **475.1 ns** |  **5.74 ns** |  **5.36 ns** | **0.0010** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **510.9 ns** |  **8.44 ns** |  **7.90 ns** | **0.0010** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **807.8 ns** | **10.05 ns** |  **8.91 ns** | **0.0067** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **4,375.4 ns** | **62.87 ns** | **58.81 ns** | **0.0381** |     **680 B** |
