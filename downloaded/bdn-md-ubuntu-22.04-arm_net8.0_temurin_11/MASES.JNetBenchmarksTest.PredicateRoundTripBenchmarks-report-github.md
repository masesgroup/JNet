```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev  | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|--------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,054.7 ns** |  **5.65 ns** | **5.29 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,069.4 ns** |  **7.83 ns** | **7.33 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,281.3 ns** |  **6.97 ns** | **6.52 ns** | **0.0019** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **4,687.6 ns** |  **9.07 ns** | **8.48 ns** | **0.0076** |     **792 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **444.5 ns** |  **0.70 ns** | **0.58 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **445.3 ns** |  **1.35 ns** | **1.26 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **632.1 ns** |  **0.64 ns** | **0.54 ns** | **0.0010** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **4,069.0 ns** | **10.62 ns** | **9.93 ns** | **0.0076** |     **712 B** |
