```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev     | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|-----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **592.91 ns** |  **0.795 ns** |   **0.620 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **591.45 ns** |  **0.834 ns** |   **0.651 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **809.16 ns** |  **7.593 ns** |   **7.102 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,193.22 ns** | **79.614 ns** | **108.976 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **42.70 ns** |  **0.148 ns** |   **0.138 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **42.14 ns** |  **0.026 ns** |   **0.025 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **252.68 ns** |  **0.451 ns** |   **0.422 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,597.22 ns** | **32.772 ns** |  **40.247 ns** |      **-** |     **656 B** |
