```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **619.23 ns** |  **0.686 ns** |  **0.642 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **619.52 ns** |  **1.009 ns** |  **0.842 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **811.47 ns** |  **0.561 ns** |  **0.525 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,240.38 ns** | **14.694 ns** | **13.745 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **59.39 ns** |  **0.023 ns** |  **0.021 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **64.46 ns** |  **1.256 ns** |  **1.880 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **253.15 ns** |  **0.409 ns** |  **0.382 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,633.03 ns** | **11.623 ns** | **10.872 ns** | **0.0100** |     **688 B** |
