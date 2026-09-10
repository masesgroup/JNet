```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **583.47 ns** |  **2.019 ns** |  **1.576 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **587.46 ns** |  **0.893 ns** |  **0.697 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **797.17 ns** |  **4.506 ns** |  **3.994 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **5,884.88 ns** | **67.079 ns** | **71.774 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **42.66 ns** |  **0.145 ns** |  **0.136 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **41.49 ns** |  **0.018 ns** |  **0.016 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **253.28 ns** |  **0.212 ns** |  **0.198 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,552.47 ns** | **19.347 ns** | **21.504 ns** |      **-** |     **656 B** |
