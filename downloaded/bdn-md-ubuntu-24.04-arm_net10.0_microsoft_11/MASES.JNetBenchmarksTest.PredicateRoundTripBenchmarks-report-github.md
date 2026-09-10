```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,065.1 ns** |  **9.19 ns** |  **8.59 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,079.5 ns** |  **5.91 ns** |  **5.24 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,307.3 ns** | **11.92 ns** | **11.15 ns** | **0.0019** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **4,882.1 ns** | **15.81 ns** | **14.01 ns** | **0.0076** |     **760 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **456.9 ns** |  **0.80 ns** |  **0.67 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **457.4 ns** |  **0.60 ns** |  **0.56 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **694.9 ns** |  **4.15 ns** |  **3.88 ns** | **0.0010** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **4,139.8 ns** |  **7.92 ns** |  **7.02 ns** | **0.0076** |     **680 B** |
