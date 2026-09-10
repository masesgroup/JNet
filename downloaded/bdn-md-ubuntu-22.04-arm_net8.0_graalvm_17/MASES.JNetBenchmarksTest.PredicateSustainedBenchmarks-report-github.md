```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **603.36 ns** |  **0.713 ns** |  **0.667 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **610.54 ns** |  **1.948 ns** |  **1.726 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **813.39 ns** |  **8.501 ns** |  **7.952 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,240.31 ns** | **14.521 ns** | **13.583 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **51.18 ns** |  **0.021 ns** |  **0.020 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **50.85 ns** |  **0.025 ns** |  **0.024 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **243.58 ns** |  **0.291 ns** |  **0.272 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,731.46 ns** | **27.530 ns** | **25.752 ns** | **0.0100** |     **688 B** |
