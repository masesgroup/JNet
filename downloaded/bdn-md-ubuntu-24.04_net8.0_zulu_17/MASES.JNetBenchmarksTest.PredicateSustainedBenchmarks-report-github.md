```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **566.70 ns** |  **4.698 ns** |  **4.164 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **557.39 ns** |  **2.954 ns** |  **2.619 ns** | **0.0044** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **744.99 ns** |  **8.998 ns** |  **7.976 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,128.30 ns** | **17.425 ns** | **16.299 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **37.54 ns** |  **0.226 ns** |  **0.200 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **37.99 ns** |  **0.240 ns** |  **0.213 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **193.93 ns** |  **2.399 ns** |  **2.244 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,463.16 ns** | **21.782 ns** | **18.189 ns** | **0.0400** |     **688 B** |
