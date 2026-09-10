```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error   | StdDev  | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|--------:|--------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,024.3 ns** | **3.14 ns** | **2.94 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,046.5 ns** | **7.36 ns** | **6.89 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,259.9 ns** | **5.70 ns** | **5.05 ns** | **0.0019** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **4,681.6 ns** | **9.07 ns** | **8.48 ns** | **0.0076** |     **792 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **435.3 ns** | **0.80 ns** | **0.71 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **430.3 ns** | **0.78 ns** | **0.73 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **636.1 ns** | **0.93 ns** | **0.78 ns** | **0.0010** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **4,051.4 ns** | **8.15 ns** | **7.62 ns** | **0.0076** |     **712 B** |
