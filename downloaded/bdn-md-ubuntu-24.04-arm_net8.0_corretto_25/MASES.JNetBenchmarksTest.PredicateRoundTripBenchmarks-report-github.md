```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,036.8 ns** |  **5.50 ns** |  **5.15 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,039.8 ns** |  **6.48 ns** |  **6.06 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,246.2 ns** |  **5.51 ns** |  **4.89 ns** | **0.0019** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **4,539.5 ns** | **16.08 ns** | **12.56 ns** | **0.0076** |     **792 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **434.1 ns** |  **0.40 ns** |  **0.36 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **431.5 ns** |  **0.42 ns** |  **0.37 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **635.7 ns** |  **1.08 ns** |  **0.84 ns** | **0.0010** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **4,680.5 ns** | **46.52 ns** | **43.51 ns** | **0.0076** |     **712 B** |
