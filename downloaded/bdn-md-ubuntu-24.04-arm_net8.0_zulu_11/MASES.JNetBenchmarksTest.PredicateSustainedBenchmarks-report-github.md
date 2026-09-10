```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **628.24 ns** |  **0.555 ns** |  **0.433 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **628.45 ns** |  **0.393 ns** |  **0.348 ns** |      **-** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **812.52 ns** |  **5.744 ns** |  **5.373 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,348.03 ns** | **11.806 ns** | **11.044 ns** | **0.0100** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **59.27 ns** |  **1.180 ns** |  **1.211 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **63.02 ns** |  **1.223 ns** |  **2.009 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **255.63 ns** |  **0.710 ns** |  **0.664 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,674.93 ns** | **20.208 ns** | **18.902 ns** | **0.0100** |     **688 B** |
