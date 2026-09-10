```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **553.1 ns** |     **0.58 ns** |     **0.52 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,411.5 ns |    16.17 ns |    14.34 ns |    13.40 |    0.03 | 0.0305 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,225.4 ns |     1.77 ns |     1.66 ns |     2.22 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,223.7 ns |     2.21 ns |     2.07 ns |     2.21 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   9,220.6 ns |    22.04 ns |    20.62 ns |    16.67 |    0.04 | 0.0458 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **544.3 ns** |     **0.67 ns** |     **0.56 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 606,405.8 ns | 1,230.84 ns | 1,091.11 ns | 1,114.13 |    2.23 | 1.9531 |      - |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   2,004.8 ns |     5.79 ns |     5.13 ns |     3.68 |    0.01 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   2,016.5 ns |     8.68 ns |     8.12 ns |     3.70 |    0.01 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 781,887.9 ns |   476.65 ns |   398.02 ns | 1,436.54 |    1.58 | 3.9063 | 0.9766 |  265888 B |      772.93 |
