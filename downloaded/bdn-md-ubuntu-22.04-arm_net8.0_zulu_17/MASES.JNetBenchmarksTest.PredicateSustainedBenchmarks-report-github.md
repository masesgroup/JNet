```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **612.95 ns** |  **3.714 ns** |  **3.474 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **615.77 ns** |  **0.864 ns** |  **0.766 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **809.29 ns** |  **6.796 ns** |  **6.357 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,328.80 ns** | **28.784 ns** | **26.924 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **50.42 ns** |  **0.734 ns** |  **0.687 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **51.83 ns** |  **0.996 ns** |  **1.186 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **237.98 ns** |  **0.518 ns** |  **0.485 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,788.60 ns** | **27.424 ns** | **25.653 ns** | **0.0100** |     **688 B** |
