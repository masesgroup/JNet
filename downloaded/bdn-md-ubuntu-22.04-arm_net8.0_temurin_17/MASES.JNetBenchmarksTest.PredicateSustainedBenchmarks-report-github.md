```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **562.20 ns** |  **0.564 ns** |  **0.500 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **579.34 ns** |  **0.369 ns** |  **0.308 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **759.37 ns** |  **6.347 ns** |  **5.937 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,210.80 ns** | **35.286 ns** | **33.007 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **50.81 ns** |  **0.951 ns** |  **1.095 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **53.20 ns** |  **0.615 ns** |  **0.576 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **238.91 ns** |  **0.330 ns** |  **0.293 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,471.11 ns** |  **5.317 ns** |  **4.151 ns** | **0.0100** |     **688 B** |
