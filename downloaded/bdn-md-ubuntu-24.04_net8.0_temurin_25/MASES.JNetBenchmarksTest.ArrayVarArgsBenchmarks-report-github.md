```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **427.4 ns** |     **5.41 ns** |     **4.79 ns** |     **1.00** |    **0.02** | **0.0038** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   5,453.5 ns |    38.72 ns |    32.33 ns |    12.76 |    0.15 | 0.0229 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |     871.3 ns |    14.99 ns |    13.29 ns |     2.04 |    0.04 | 0.0048 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |     876.5 ns |     9.20 ns |     7.68 ns |     2.05 |    0.03 | 0.0048 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   7,040.6 ns |   117.51 ns |   104.17 ns |    16.48 |    0.29 | 0.0381 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **430.8 ns** |     **7.74 ns** |     **7.24 ns** |     **1.00** |    **0.02** | **0.0038** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 445,512.7 ns | 6,840.25 ns | 5,711.92 ns | 1,034.41 |   20.95 | 1.4648 | 0.4883 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,614.9 ns |    19.52 ns |    16.30 ns |     3.75 |    0.07 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,626.4 ns |     9.89 ns |     8.26 ns |     3.78 |    0.06 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 595,955.8 ns | 4,787.95 ns | 3,998.15 ns | 1,383.72 |   23.95 | 2.9297 | 0.9766 |  265888 B |      772.93 |
