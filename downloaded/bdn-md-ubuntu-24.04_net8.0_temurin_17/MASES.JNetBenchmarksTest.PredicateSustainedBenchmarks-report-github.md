```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Intel Xeon 6973P-C 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **339.43 ns** |  **1.997 ns** |  **1.868 ns** | **0.0007** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **351.78 ns** |  **6.671 ns** |  **6.240 ns** | **0.0007** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **476.38 ns** |  **4.984 ns** |  **4.418 ns** | **0.0018** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **2,390.98 ns** | **41.835 ns** | **44.763 ns** | **0.0067** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **37.80 ns** |  **0.722 ns** |  **0.772 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **37.46 ns** |  **0.126 ns** |  **0.105 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **139.96 ns** |  **1.091 ns** |  **0.852 ns** | **0.0011** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **2,022.14 ns** | **17.890 ns** | **15.859 ns** | **0.0067** |     **688 B** |
