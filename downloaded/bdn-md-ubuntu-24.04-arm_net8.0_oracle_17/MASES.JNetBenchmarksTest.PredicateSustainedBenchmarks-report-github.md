```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Median      | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|------------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **617.09 ns** |  **0.777 ns** |  **0.689 ns** |   **616.81 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **621.17 ns** |  **0.859 ns** |  **0.762 ns** |   **621.19 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **803.31 ns** |  **5.897 ns** |  **5.516 ns** |   **798.65 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,274.41 ns** | **17.842 ns** | **16.690 ns** | **4,271.51 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **52.03 ns** |  **1.031 ns** |  **1.059 ns** |    **52.49 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **51.85 ns** |  **1.031 ns** |  **1.187 ns** |    **52.32 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **237.64 ns** |  **0.314 ns** |  **0.294 ns** |   **237.64 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,646.46 ns** | **32.886 ns** | **30.761 ns** | **3,652.90 ns** | **0.0100** |     **688 B** |
