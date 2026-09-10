```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               |   **721.1 ns** | **11.92 ns** | **10.57 ns** | **0.0010** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                |   **728.7 ns** |  **7.57 ns** |  **6.71 ns** | **0.0010** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               |   **902.0 ns** |  **9.09 ns** |  **8.51 ns** | **0.0019** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **3,189.7 ns** | **44.32 ns** | **41.45 ns** | **0.0076** |     **792 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **300.7 ns** |  **5.62 ns** |  **5.26 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **297.8 ns** |  **5.90 ns** |  **6.06 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **461.5 ns** |  **4.92 ns** |  **4.36 ns** | **0.0010** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **2,770.8 ns** | **38.04 ns** | **31.76 ns** | **0.0076** |     **712 B** |
