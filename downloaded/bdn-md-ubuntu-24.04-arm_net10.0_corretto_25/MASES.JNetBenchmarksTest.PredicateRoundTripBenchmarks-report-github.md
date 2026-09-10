```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|----------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,057.7 ns** |  **8.68 ns** |   **8.12 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,058.4 ns** |  **7.64 ns** |   **7.15 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,353.5 ns** | **14.63 ns** |  **12.97 ns** | **0.0019** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **7,082.8 ns** | **82.06 ns** | **143.72 ns** |      **-** |     **760 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **457.2 ns** |  **0.63 ns** |   **0.59 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **459.0 ns** |  **0.56 ns** |   **0.50 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **693.7 ns** |  **1.52 ns** |   **1.18 ns** | **0.0010** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **5,739.7 ns** | **56.07 ns** |  **46.82 ns** | **0.0076** |     **680 B** |
