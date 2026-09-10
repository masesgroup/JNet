```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **579.06 ns** |  **1.324 ns** |  **1.033 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **573.91 ns** |  **0.915 ns** |  **0.811 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **778.24 ns** |  **4.609 ns** |  **4.311 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,355.76 ns** | **77.311 ns** | **60.359 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **41.69 ns** |  **0.466 ns** |  **0.436 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **41.68 ns** |  **0.061 ns** |  **0.057 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **256.32 ns** |  **0.335 ns** |  **0.314 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,712.41 ns** | **36.726 ns** | **40.821 ns** |      **-** |     **656 B** |
