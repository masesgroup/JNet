```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method             | ByIndex | ContinueFirstCheck | ContinueSecondCheck | Mean        | Error     | StdDev    | Gen0   | Allocated |
|------------------- |-------- |------------------- |-------------------- |------------:|----------:|----------:|-------:|----------:|
| **PredicateSustained** | **False**   | **False**              | **False**               |   **601.19 ns** |  **1.205 ns** |  **1.127 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **False**              | **True**                |   **595.26 ns** |  **0.643 ns** |  **0.537 ns** | **0.0011** |      **80 B** |
| **PredicateSustained** | **False**   | **True**               | **False**               |   **811.29 ns** |  **6.773 ns** |  **6.335 ns** | **0.0014** |     **176 B** |
| **PredicateSustained** | **False**   | **True**               | **True**                | **4,802.21 ns** | **46.202 ns** | **40.957 ns** | **0.0100** |     **736 B** |
| **PredicateSustained** | **True**    | **False**              | **False**               |    **43.89 ns** |  **0.822 ns** |  **0.807 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **False**              | **True**                |    **43.76 ns** |  **0.476 ns** |  **0.422 ns** |      **-** |         **-** |
| **PredicateSustained** | **True**    | **True**               | **False**               |   **258.20 ns** |  **1.188 ns** |  **1.111 ns** | **0.0013** |      **96 B** |
| **PredicateSustained** | **True**    | **True**               | **True**                | **5,011.73 ns** | **92.882 ns** | **91.223 ns** |      **-** |     **656 B** |
