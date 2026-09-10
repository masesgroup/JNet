```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **596.28 ns** |  **0.547 ns** |  **0.457 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **585.70 ns** |  **0.709 ns** |  **0.664 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **782.01 ns** |  **6.290 ns** |  **5.884 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,383.48 ns** | **52.459 ns** | **49.070 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **51.13 ns** |  **1.020 ns** |  **1.214 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **52.77 ns** |  **0.995 ns** |  **1.065 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **238.14 ns** |  **0.279 ns** |  **0.247 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,433.01 ns** | **15.800 ns** | **14.779 ns** | **0.0100** |     **688 B** |
