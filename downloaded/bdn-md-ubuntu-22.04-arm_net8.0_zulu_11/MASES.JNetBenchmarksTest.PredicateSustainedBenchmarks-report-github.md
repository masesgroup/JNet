```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **630.13 ns** |  **0.535 ns** |  **0.418 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **626.28 ns** |  **1.227 ns** |  **1.148 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **811.95 ns** |  **0.532 ns** |  **0.471 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,304.79 ns** | **12.080 ns** | **11.299 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **58.93 ns** |  **1.174 ns** |  **1.352 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **59.30 ns** |  **1.154 ns** |  **1.235 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **250.53 ns** |  **0.672 ns** |  **0.628 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,631.19 ns** | **20.047 ns** | **18.752 ns** | **0.0100** |     **688 B** |
