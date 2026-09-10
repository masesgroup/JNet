```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Median     | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-----------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,041.3 ns** |  **7.97 ns** |  **7.45 ns** | **1,035.4 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,044.4 ns** |  **4.65 ns** |  **4.12 ns** | **1,045.9 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,232.8 ns** |  **8.94 ns** |  **8.37 ns** | **1,226.8 ns** | **0.0019** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **4,645.8 ns** | **15.30 ns** | **14.31 ns** | **4,643.9 ns** | **0.0076** |     **792 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **433.5 ns** |  **0.35 ns** |  **0.31 ns** |   **433.4 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **421.2 ns** |  **0.40 ns** |  **0.35 ns** |   **421.1 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **632.4 ns** |  **0.80 ns** |  **0.62 ns** |   **632.2 ns** | **0.0010** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **3,862.7 ns** |  **9.88 ns** |  **9.24 ns** | **3,861.2 ns** | **0.0076** |     **712 B** |
