```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **626.07 ns** |  **0.422 ns** |  **0.329 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **622.44 ns** |  **3.115 ns** |  **2.601 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **815.33 ns** |  **5.587 ns** |  **5.226 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,200.18 ns** | **14.781 ns** | **13.103 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **51.69 ns** |  **0.016 ns** |  **0.015 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **53.21 ns** |  **0.026 ns** |  **0.024 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **244.45 ns** |  **0.110 ns** |  **0.086 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,730.51 ns** | **28.708 ns** | **26.853 ns** | **0.0100** |     **688 B** |
