```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **586.06 ns** |  **0.291 ns** |  **0.258 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **587.67 ns** |  **1.609 ns** |  **1.426 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **798.14 ns** |  **7.576 ns** |  **7.086 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,102.63 ns** | **15.217 ns** | **14.234 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **45.42 ns** |  **0.690 ns** |  **0.645 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **46.24 ns** |  **0.850 ns** |  **0.945 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **259.68 ns** |  **0.486 ns** |  **0.431 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,422.44 ns** | **24.603 ns** | **23.014 ns** |      **-** |     **656 B** |
