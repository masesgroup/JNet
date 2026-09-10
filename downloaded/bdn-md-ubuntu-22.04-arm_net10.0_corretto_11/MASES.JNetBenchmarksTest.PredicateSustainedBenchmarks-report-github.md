```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **604.29 ns** |  **1.921 ns** |  **1.797 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **604.42 ns** |  **0.494 ns** |  **0.412 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **819.64 ns** |  **2.632 ns** |  **2.198 ns** | **0.0017** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,294.36 ns** | **19.143 ns** | **17.907 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **50.59 ns** |  **0.691 ns** |  **0.646 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **52.30 ns** |  **0.747 ns** |  **0.699 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **277.38 ns** |  **0.510 ns** |  **0.477 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,553.19 ns** |  **9.562 ns** |  **8.477 ns** |      **-** |     **656 B** |
