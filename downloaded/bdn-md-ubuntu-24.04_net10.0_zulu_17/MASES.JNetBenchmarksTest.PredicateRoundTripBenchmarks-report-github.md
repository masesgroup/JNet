```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               |   **868.6 ns** |  **9.64 ns** |  **8.55 ns** | **0.0010** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                |   **862.4 ns** | **10.22 ns** |  **9.56 ns** | **0.0010** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,053.5 ns** | **15.83 ns** | **14.81 ns** | **0.0019** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **3,844.0 ns** | **67.04 ns** | **62.71 ns** | **0.0076** |     **760 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **336.5 ns** |  **3.89 ns** |  **3.64 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **331.4 ns** |  **4.88 ns** |  **4.56 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **536.5 ns** |  **6.20 ns** |  **5.80 ns** | **0.0010** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **3,370.0 ns** | **55.90 ns** | **52.29 ns** | **0.0076** |     **680 B** |
