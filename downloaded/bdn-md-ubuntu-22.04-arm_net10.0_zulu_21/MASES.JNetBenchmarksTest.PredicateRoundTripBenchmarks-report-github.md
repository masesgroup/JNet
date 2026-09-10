```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,041.2 ns** |  **5.94 ns** |  **5.27 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,048.2 ns** |  **8.82 ns** |  **8.25 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,284.1 ns** |  **9.46 ns** |  **8.85 ns** | **0.0019** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **5,084.5 ns** | **33.22 ns** | **31.07 ns** | **0.0076** |     **760 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **459.4 ns** |  **0.49 ns** |  **0.43 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **465.1 ns** |  **0.84 ns** |  **0.66 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **683.2 ns** |  **1.66 ns** |  **1.30 ns** | **0.0010** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **4,320.1 ns** | **31.82 ns** | **29.77 ns** | **0.0076** |     **680 B** |
