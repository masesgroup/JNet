```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **596.08 ns** |  **0.348 ns** |  **0.308 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **597.52 ns** |  **0.791 ns** |  **0.617 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **811.64 ns** |  **5.998 ns** |  **5.610 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,426.73 ns** | **56.666 ns** | **62.984 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **41.94 ns** |  **0.253 ns** |  **0.224 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **41.49 ns** |  **0.707 ns** |  **0.662 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **254.33 ns** |  **0.345 ns** |  **0.305 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,435.50 ns** | **26.355 ns** | **20.576 ns** |      **-** |     **656 B** |
