```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **586.37 ns** |  **0.603 ns** |  **0.564 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **590.98 ns** |  **1.023 ns** |  **0.855 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **787.59 ns** |  **8.592 ns** |  **8.037 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,117.42 ns** | **19.744 ns** | **18.469 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **46.04 ns** |  **0.891 ns** |  **1.219 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **46.61 ns** |  **0.891 ns** |  **0.953 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **256.09 ns** |  **0.350 ns** |  **0.327 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,338.10 ns** | **17.811 ns** | **16.661 ns** |      **-** |     **656 B** |
