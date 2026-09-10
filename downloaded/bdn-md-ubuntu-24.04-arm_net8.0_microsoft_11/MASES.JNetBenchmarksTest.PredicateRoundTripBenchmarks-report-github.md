```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error   | StdDev  | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|--------:|--------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,022.8 ns** | **2.22 ns** | **1.97 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,040.9 ns** | **4.81 ns** | **4.50 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,255.9 ns** | **9.78 ns** | **9.15 ns** | **0.0019** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **4,773.5 ns** | **9.08 ns** | **8.50 ns** | **0.0076** |     **792 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **446.5 ns** | **0.73 ns** | **0.68 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **437.5 ns** | **1.10 ns** | **1.03 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **639.1 ns** | **0.35 ns** | **0.30 ns** | **0.0010** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **3,985.7 ns** | **3.38 ns** | **3.00 ns** | **0.0076** |     **712 B** |
