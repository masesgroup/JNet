```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **628.12 ns** |  **0.234 ns** |  **0.195 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **630.29 ns** |  **3.313 ns** |  **2.587 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **831.85 ns** |  **9.738 ns** |  **9.109 ns** | **0.0017** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,248.44 ns** | **15.002 ns** | **14.033 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **59.18 ns** |  **1.141 ns** |  **1.358 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **59.16 ns** |  **1.129 ns** |  **1.344 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **253.01 ns** |  **0.622 ns** |  **0.582 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,583.75 ns** |  **9.324 ns** |  **8.722 ns** | **0.0100** |     **688 B** |
