```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **592.68 ns** |  **0.354 ns** |  **0.296 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **589.82 ns** |  **0.354 ns** |  **0.296 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **789.24 ns** |  **6.964 ns** |  **6.514 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,156.79 ns** | **27.710 ns** | **25.920 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **53.65 ns** |  **1.032 ns** |  **1.229 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **52.55 ns** |  **1.057 ns** |  **1.131 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **241.35 ns** |  **0.473 ns** |  **0.442 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,531.72 ns** | **19.731 ns** | **18.456 ns** | **0.0100** |     **688 B** |
