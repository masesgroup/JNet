```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **545.3 ns** |     **0.47 ns** |     **0.42 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,078.7 ns |     9.99 ns |     8.86 ns |    12.98 |    0.02 | 0.0305 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,207.9 ns |     1.12 ns |     0.99 ns |     2.22 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,198.5 ns |     0.69 ns |     0.58 ns |     2.20 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   8,970.9 ns |    32.70 ns |    28.99 ns |    16.45 |    0.05 | 0.0458 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **541.5 ns** |     **0.45 ns** |     **0.42 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 561,310.7 ns | 1,341.64 ns | 1,254.97 ns | 1,036.51 |    2.38 | 1.9531 |      - |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,702.8 ns |     5.56 ns |     4.93 ns |     3.14 |    0.01 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,707.5 ns |    10.56 ns |     9.36 ns |     3.15 |    0.02 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 748,963.2 ns | 2,311.36 ns | 1,930.09 ns | 1,383.03 |    3.59 | 3.9063 | 0.9766 |  265888 B |      772.93 |
