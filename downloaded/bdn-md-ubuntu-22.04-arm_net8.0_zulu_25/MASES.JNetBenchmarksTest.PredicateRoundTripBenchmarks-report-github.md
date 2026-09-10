```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev  | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|--------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,012.9 ns** |  **5.74 ns** | **5.37 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,031.4 ns** |  **7.31 ns** | **6.84 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,239.5 ns** |  **6.94 ns** | **6.49 ns** | **0.0019** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **4,500.6 ns** |  **6.29 ns** | **5.25 ns** | **0.0076** |     **792 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **430.4 ns** |  **0.37 ns** | **0.31 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **432.5 ns** |  **0.56 ns** | **0.53 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **628.7 ns** |  **0.97 ns** | **0.76 ns** | **0.0010** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **3,836.4 ns** | **11.68 ns** | **9.75 ns** | **0.0076** |     **712 B** |
