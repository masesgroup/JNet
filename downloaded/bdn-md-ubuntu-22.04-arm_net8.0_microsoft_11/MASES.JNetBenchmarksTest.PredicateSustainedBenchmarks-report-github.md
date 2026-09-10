```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **615.53 ns** |  **0.728 ns** |  **0.568 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **612.30 ns** |  **0.357 ns** |  **0.298 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **808.65 ns** |  **5.710 ns** |  **5.341 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,313.14 ns** | **20.119 ns** | **18.819 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **59.05 ns** |  **1.152 ns** |  **1.281 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **61.55 ns** |  **1.173 ns** |  **1.304 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **251.47 ns** |  **0.425 ns** |  **0.397 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,660.15 ns** | **20.114 ns** | **16.796 ns** | **0.0100** |     **688 B** |
