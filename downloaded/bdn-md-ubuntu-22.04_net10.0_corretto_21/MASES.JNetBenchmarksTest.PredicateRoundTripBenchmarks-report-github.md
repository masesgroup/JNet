```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Intel Xeon Platinum 8370C CPU 2.80GHz (Max: 3.33GHz), 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,314.3 ns** | **15.80 ns** | **14.78 ns** | **0.0038** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,286.9 ns** | **12.47 ns** | **11.66 ns** | **0.0038** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,639.2 ns** |  **9.40 ns** |  **7.34 ns** | **0.0076** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **5,234.9 ns** | **37.97 ns** | **35.52 ns** | **0.0229** |     **760 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **472.5 ns** |  **7.08 ns** |  **6.62 ns** | **0.0010** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **487.5 ns** |  **6.38 ns** |  **5.66 ns** | **0.0010** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **875.0 ns** |  **7.17 ns** |  **6.71 ns** | **0.0048** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **4,480.4 ns** | **25.97 ns** | **23.02 ns** | **0.0229** |     **680 B** |
