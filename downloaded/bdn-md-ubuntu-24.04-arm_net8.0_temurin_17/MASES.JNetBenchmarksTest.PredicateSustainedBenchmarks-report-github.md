```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **595.76 ns** |  **1.452 ns** |  **1.212 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **588.44 ns** |  **0.288 ns** |  **0.241 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **797.51 ns** |  **5.918 ns** |  **5.536 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,278.50 ns** | **21.085 ns** | **19.723 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **50.88 ns** |  **0.958 ns** |  **1.025 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **50.84 ns** |  **0.965 ns** |  **0.991 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **243.16 ns** |  **0.386 ns** |  **0.342 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,623.90 ns** | **20.725 ns** | **19.386 ns** | **0.0100** |     **688 B** |
