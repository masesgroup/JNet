```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **604.21 ns** |  **0.943 ns** |  **0.882 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **599.87 ns** |  **0.280 ns** |  **0.233 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **822.18 ns** |  **1.545 ns** |  **1.206 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,664.72 ns** | **48.415 ns** | **45.287 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **44.73 ns** |  **0.025 ns** |  **0.024 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **44.34 ns** |  **0.028 ns** |  **0.026 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **262.73 ns** |  **0.344 ns** |  **0.322 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,463.45 ns** | **18.459 ns** | **16.364 ns** |      **-** |     **656 B** |
