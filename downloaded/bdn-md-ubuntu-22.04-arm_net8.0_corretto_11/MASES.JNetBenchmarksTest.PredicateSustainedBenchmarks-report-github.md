```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **618.79 ns** |  **3.156 ns** |  **2.798 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **612.86 ns** |  **0.632 ns** |  **0.528 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **804.68 ns** |  **1.718 ns** |  **1.342 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,364.51 ns** | **15.824 ns** | **14.802 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **59.84 ns** |  **1.146 ns** |  **1.226 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **60.18 ns** |  **0.517 ns** |  **0.484 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **249.22 ns** |  **0.474 ns** |  **0.443 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,616.83 ns** | **14.422 ns** | **13.490 ns** | **0.0100** |     **688 B** |
