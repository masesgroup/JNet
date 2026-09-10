```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.87GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **684.52 ns** | **12.041 ns** | **11.264 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **663.10 ns** | **10.636 ns** | **10.446 ns** | **0.0038** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **904.02 ns** | **17.476 ns** | **15.492 ns** | **0.0100** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,764.68 ns** | **93.386 ns** | **91.717 ns** | **0.0400** |     **768 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **47.74 ns** |  **0.613 ns** |  **0.573 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **47.52 ns** |  **0.836 ns** |  **0.782 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **244.21 ns** |  **2.879 ns** |  **2.693 ns** | **0.0056** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **3,911.31 ns** | **63.419 ns** | **59.322 ns** | **0.0400** |     **688 B** |
