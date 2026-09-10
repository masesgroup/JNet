```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 3.24GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,273.9 ns** | **23.25 ns** | **22.83 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,262.8 ns** | **22.96 ns** | **21.48 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,592.0 ns** | **12.73 ns** | **10.63 ns** | **0.0114** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **5,436.8 ns** | **67.30 ns** | **62.95 ns** | **0.0458** |     **792 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **499.9 ns** |  **9.61 ns** |  **8.52 ns** | **0.0010** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **506.6 ns** |  **9.96 ns** |  **9.32 ns** | **0.0010** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **781.8 ns** |  **6.30 ns** |  **5.58 ns** | **0.0067** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **4,651.1 ns** | **62.70 ns** | **55.59 ns** | **0.0381** |     **712 B** |
