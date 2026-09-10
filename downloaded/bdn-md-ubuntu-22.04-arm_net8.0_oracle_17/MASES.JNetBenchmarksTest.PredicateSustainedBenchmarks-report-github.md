```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **603.48 ns** |  **1.395 ns** |  **1.305 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **590.53 ns** |  **1.182 ns** |  **0.987 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **799.13 ns** |  **7.502 ns** |  **7.018 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,723.72 ns** | **47.762 ns** | **44.677 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **53.13 ns** |  **0.993 ns** |  **0.880 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **52.00 ns** |  **1.036 ns** |  **0.969 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **236.33 ns** |  **0.275 ns** |  **0.230 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,613.94 ns** | **14.544 ns** | **13.605 ns** | **0.0100** |     **688 B** |
