```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 3.14GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,360.2 ns** | **26.85 ns** | **31.96 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,359.5 ns** | **26.57 ns** | **24.85 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,624.1 ns** | **17.19 ns** | **16.08 ns** | **0.0114** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **5,776.7 ns** | **71.54 ns** | **66.92 ns** | **0.0458** |     **792 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **510.2 ns** | **10.02 ns** | **11.93 ns** | **0.0010** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **500.8 ns** |  **9.94 ns** | **10.20 ns** | **0.0010** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **803.3 ns** | **10.61 ns** |  **9.92 ns** | **0.0067** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **4,806.3 ns** | **44.74 ns** | **39.66 ns** | **0.0381** |     **712 B** |
