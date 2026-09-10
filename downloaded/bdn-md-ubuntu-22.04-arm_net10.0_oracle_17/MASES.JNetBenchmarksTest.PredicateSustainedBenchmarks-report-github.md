```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **595.11 ns** |  **0.941 ns** |  **0.786 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **593.68 ns** |  **1.323 ns** |  **1.173 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **792.19 ns** |  **0.675 ns** |  **0.527 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,314.07 ns** | **32.687 ns** | **30.575 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **46.88 ns** |  **0.659 ns** |  **0.617 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **44.22 ns** |  **0.756 ns** |  **0.707 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **260.16 ns** |  **0.687 ns** |  **0.642 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,502.24 ns** | **21.661 ns** | **18.088 ns** |      **-** |     **656 B** |
