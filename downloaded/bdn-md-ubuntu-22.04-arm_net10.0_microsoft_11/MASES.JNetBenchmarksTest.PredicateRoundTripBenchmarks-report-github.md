```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,060.9 ns** |  **5.88 ns** |  **5.50 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,066.2 ns** |  **3.86 ns** |  **3.42 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,274.2 ns** | **10.64 ns** |  **9.95 ns** | **0.0019** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **4,954.6 ns** | **11.10 ns** | **10.39 ns** | **0.0076** |     **760 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **452.2 ns** |  **1.82 ns** |  **1.70 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **451.2 ns** |  **0.74 ns** |  **0.69 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **691.7 ns** |  **0.32 ns** |  **0.25 ns** | **0.0010** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **5,176.4 ns** | **29.02 ns** | **27.15 ns** | **0.0076** |     **680 B** |
