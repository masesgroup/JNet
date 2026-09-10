```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.75GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **674.46 ns** |  **8.655 ns** |  **7.673 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **664.76 ns** | **13.242 ns** | **14.718 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **919.96 ns** | **18.002 ns** | **16.839 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,579.48 ns** | **29.200 ns** | **22.798 ns** | **0.0400** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **33.47 ns** |  **0.266 ns** |  **0.222 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **33.69 ns** |  **0.627 ns** |  **0.586 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **243.49 ns** |  **3.400 ns** |  **3.180 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,726.37 ns** | **35.219 ns** | **31.220 ns** | **0.0300** |     **656 B** |
