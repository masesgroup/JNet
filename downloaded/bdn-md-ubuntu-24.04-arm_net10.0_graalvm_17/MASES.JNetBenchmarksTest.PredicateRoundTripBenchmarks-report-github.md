```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,054.0 ns** |  **5.81 ns** |  **5.15 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,063.3 ns** |  **7.37 ns** |  **6.89 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,410.3 ns** | **18.28 ns** | **17.10 ns** | **0.0019** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **5,297.0 ns** | **36.54 ns** | **34.18 ns** | **0.0076** |     **760 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **455.7 ns** |  **0.20 ns** |  **0.18 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **459.2 ns** |  **0.50 ns** |  **0.47 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **684.4 ns** |  **0.31 ns** |  **0.25 ns** | **0.0010** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **4,587.2 ns** | **41.15 ns** | **38.49 ns** | **0.0076** |     **680 B** |
