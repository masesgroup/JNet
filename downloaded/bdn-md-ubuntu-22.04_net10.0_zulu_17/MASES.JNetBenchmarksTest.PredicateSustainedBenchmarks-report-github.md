```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.86GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **637.65 ns** | **12.496 ns** | **12.833 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **691.84 ns** |  **8.149 ns** |  **7.224 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **911.00 ns** | **17.118 ns** | **17.579 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,474.02 ns** | **46.124 ns** | **40.888 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **34.84 ns** |  **0.382 ns** |  **0.357 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **33.96 ns** |  **0.470 ns** |  **0.440 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **247.10 ns** |  **2.024 ns** |  **1.690 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,650.69 ns** | **46.585 ns** | **43.576 ns** | **0.0300** |     **656 B** |
