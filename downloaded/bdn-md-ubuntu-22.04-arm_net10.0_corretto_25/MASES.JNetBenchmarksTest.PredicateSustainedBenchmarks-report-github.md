```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **588.90 ns** |  **0.908 ns** |  **0.709 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **592.43 ns** |  **1.215 ns** |  **0.949 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **789.49 ns** |  **5.505 ns** |  **5.149 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,572.70 ns** | **59.467 ns** | **46.428 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **42.21 ns** |  **0.797 ns** |  **0.745 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **41.88 ns** |  **0.038 ns** |  **0.036 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **258.49 ns** |  **2.011 ns** |  **1.881 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,640.05 ns** | **33.407 ns** | **41.027 ns** |      **-** |     **656 B** |
