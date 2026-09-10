```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error   | StdDev  | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|--------:|--------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,023.0 ns** | **7.29 ns** | **6.47 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,010.8 ns** | **9.33 ns** | **8.73 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,223.3 ns** | **5.25 ns** | **4.65 ns** | **0.0019** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **4,445.3 ns** | **8.72 ns** | **8.16 ns** | **0.0076** |     **792 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **426.0 ns** | **1.45 ns** | **1.35 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **424.1 ns** | **0.95 ns** | **0.85 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **617.9 ns** | **1.24 ns** | **0.96 ns** | **0.0010** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **3,763.4 ns** | **9.91 ns** | **9.27 ns** | **0.0076** |     **712 B** |
