```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **597.49 ns** |  **0.203 ns** |  **0.159 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **596.26 ns** |  **0.651 ns** |  **0.544 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **793.53 ns** |  **7.913 ns** |  **7.402 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,078.85 ns** | **18.711 ns** | **17.503 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **51.70 ns** |  **0.991 ns** |  **1.101 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **52.43 ns** |  **0.963 ns** |  **1.253 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **239.12 ns** |  **0.518 ns** |  **0.459 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,384.06 ns** | **13.420 ns** | **11.896 ns** | **0.0100** |     **688 B** |
