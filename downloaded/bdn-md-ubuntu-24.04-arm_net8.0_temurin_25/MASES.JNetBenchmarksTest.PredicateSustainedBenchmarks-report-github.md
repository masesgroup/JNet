```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **589.30 ns** |  **0.930 ns** |  **0.726 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **591.39 ns** |  **0.655 ns** |  **0.511 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **789.60 ns** |  **5.566 ns** |  **5.207 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,044.15 ns** | **37.128 ns** | **34.729 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **49.05 ns** |  **0.948 ns** |  **0.931 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **48.81 ns** |  **0.939 ns** |  **1.043 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **239.44 ns** |  **0.264 ns** |  **0.234 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **4,026.81 ns** | **59.036 ns** | **76.763 ns** | **0.0100** |     **688 B** |
