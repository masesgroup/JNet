```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,321.1 ns** | **25.00 ns** | **23.39 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,276.6 ns** | **19.77 ns** | **18.49 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,631.7 ns** | **13.05 ns** | **12.20 ns** | **0.0114** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **5,253.4 ns** | **52.94 ns** | **49.52 ns** | **0.0381** |     **760 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **530.1 ns** | **10.13 ns** | **11.25 ns** | **0.0010** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **529.4 ns** | **10.20 ns** | **14.30 ns** | **0.0010** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **811.2 ns** | **11.67 ns** | **10.92 ns** | **0.0067** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **4,507.4 ns** | **76.52 ns** | **71.57 ns** | **0.0381** |     **680 B** |
