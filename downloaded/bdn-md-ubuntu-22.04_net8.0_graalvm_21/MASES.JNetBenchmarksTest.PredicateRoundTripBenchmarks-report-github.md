```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.63GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,308.0 ns** | **22.84 ns** | **21.36 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,290.6 ns** | **25.54 ns** | **29.41 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,579.4 ns** | **25.71 ns** | **24.05 ns** | **0.0114** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **5,392.9 ns** | **79.98 ns** | **74.81 ns** | **0.0458** |     **792 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **488.6 ns** |  **9.43 ns** | **10.10 ns** | **0.0010** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **490.9 ns** |  **9.60 ns** |  **9.86 ns** | **0.0010** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **740.1 ns** |  **9.67 ns** |  **8.58 ns** | **0.0067** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **4,562.2 ns** | **47.28 ns** | **44.22 ns** | **0.0381** |     **712 B** |
