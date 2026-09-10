```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **591.64 ns** |  **0.565 ns** |  **0.441 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **597.11 ns** |  **0.745 ns** |  **0.582 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **793.13 ns** |  **5.268 ns** |  **4.928 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,093.28 ns** | **14.245 ns** | **11.895 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **49.78 ns** |  **0.029 ns** |  **0.027 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **49.32 ns** |  **0.293 ns** |  **0.274 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **239.38 ns** |  **0.477 ns** |  **0.446 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,395.98 ns** | **23.319 ns** | **21.813 ns** | **0.0100** |     **688 B** |
