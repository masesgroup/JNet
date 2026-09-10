```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **607.53 ns** |  **0.667 ns** |  **0.591 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **608.16 ns** |  **0.318 ns** |  **0.282 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **826.12 ns** |  **1.901 ns** |  **1.587 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,342.00 ns** | **12.331 ns** | **11.534 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **50.81 ns** |  **0.821 ns** |  **0.768 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **51.13 ns** |  **0.389 ns** |  **0.364 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **277.79 ns** |  **0.551 ns** |  **0.516 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,535.46 ns** | **17.259 ns** | **16.144 ns** |      **-** |     **656 B** |
