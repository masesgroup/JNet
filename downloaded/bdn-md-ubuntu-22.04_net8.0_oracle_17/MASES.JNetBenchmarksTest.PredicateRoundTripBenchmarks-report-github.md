```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
INTEL XEON PLATINUM 8573C 3.50GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               |   **931.2 ns** |  **7.07 ns** |  **6.62 ns** |      **-** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                |   **936.1 ns** |  **8.97 ns** |  **8.39 ns** | **0.0010** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,151.2 ns** | **11.89 ns** | **11.12 ns** | **0.0019** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **3,932.5 ns** | **38.16 ns** | **31.87 ns** | **0.0076** |     **792 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **345.7 ns** |  **2.16 ns** |  **1.80 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **348.3 ns** |  **4.33 ns** |  **4.05 ns** |      **-** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **557.9 ns** |  **6.15 ns** |  **5.14 ns** | **0.0010** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **3,365.4 ns** | **40.47 ns** | **37.86 ns** | **0.0076** |     **712 B** |
