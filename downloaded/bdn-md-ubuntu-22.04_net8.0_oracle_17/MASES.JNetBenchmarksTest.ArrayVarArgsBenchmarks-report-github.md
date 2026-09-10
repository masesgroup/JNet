```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
INTEL XEON PLATINUM 8573C 3.50GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **528.2 ns** |     **9.93 ns** |     **8.80 ns** |     **1.00** |    **0.02** | **0.0038** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   6,919.6 ns |   106.26 ns |    94.20 ns |    13.10 |    0.27 | 0.0229 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,120.5 ns |     9.88 ns |     9.24 ns |     2.12 |    0.04 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,129.5 ns |     9.90 ns |     9.26 ns |     2.14 |    0.04 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   8,405.1 ns |    30.35 ns |    26.90 ns |    15.92 |    0.26 | 0.0305 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **525.0 ns** |     **5.49 ns** |     **5.13 ns** |     **1.00** |    **0.01** | **0.0038** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 532,619.7 ns | 5,741.19 ns | 4,794.15 ns | 1,014.68 |   13.02 | 0.9766 |      - |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,943.9 ns |     9.17 ns |     8.58 ns |     3.70 |    0.04 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,926.2 ns |    12.09 ns |    11.31 ns |     3.67 |    0.04 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 679,471.8 ns | 4,180.23 ns | 3,910.19 ns | 1,294.45 |   14.21 | 2.9297 | 0.9766 |  265888 B |      772.93 |
