```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               |   **790.9 ns** |  **5.21 ns** |  **4.88 ns** | **0.0010** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                |   **778.6 ns** |  **4.59 ns** |  **4.29 ns** | **0.0010** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               |   **955.0 ns** |  **4.08 ns** |  **3.62 ns** | **0.0019** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **3,550.2 ns** | **26.88 ns** | **25.15 ns** | **0.0076** |     **760 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **312.4 ns** |  **2.11 ns** |  **1.87 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **291.7 ns** |  **1.91 ns** |  **1.69 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **467.0 ns** |  **4.37 ns** |  **4.09 ns** | **0.0010** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **3,106.9 ns** | **15.17 ns** | **14.19 ns** | **0.0076** |     **680 B** |
