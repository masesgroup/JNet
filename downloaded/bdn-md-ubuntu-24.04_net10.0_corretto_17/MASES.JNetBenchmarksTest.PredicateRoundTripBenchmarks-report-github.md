```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 3.14GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean       | Error    | StdDev   | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |-----------:|---------:|---------:|-------:|----------:|
| **PredicateRoundTrip** | **False**   | **False**              | **False**               | **1,101.3 ns** |  **5.22 ns** |  **4.63 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **False**              | **True**                | **1,125.0 ns** | **10.53 ns** |  **9.85 ns** | **0.0057** |     **104 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **False**               | **1,342.5 ns** |  **7.23 ns** |  **6.41 ns** | **0.0114** |     **200 B** |
| **PredicateRoundTrip** | **False**   | **True**               | **True**                | **4,547.1 ns** | **20.67 ns** | **19.34 ns** | **0.0381** |     **760 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **False**               |   **430.7 ns** |  **6.08 ns** |  **5.69 ns** | **0.0014** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **False**              | **True**                |   **420.7 ns** |  **5.01 ns** |  **4.18 ns** | **0.0014** |      **24 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **False**               |   **693.1 ns** |  **4.35 ns** |  **3.86 ns** | **0.0067** |     **120 B** |
| **PredicateRoundTrip** | **True**    | **True**               | **True**                | **3,831.3 ns** | **32.25 ns** | **28.59 ns** | **0.0381** |     **680 B** |
