```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **580.85 ns** |  **1.412 ns** |  **1.102 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **579.13 ns** |  **0.547 ns** |  **0.427 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **793.30 ns** |  **7.285 ns** |  **6.815 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **3,968.03 ns** | **16.879 ns** | **16.577 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **41.78 ns** |  **0.093 ns** |  **0.087 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **40.70 ns** |  **0.029 ns** |  **0.024 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **257.75 ns** |  **0.397 ns** |  **0.371 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,283.61 ns** | **19.412 ns** | **15.156 ns** |      **-** |     **656 B** |
