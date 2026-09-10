```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Intel Xeon 6973P-C 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Median       | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|-------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **344.2 ns** |     **6.46 ns** |     **8.17 ns** |     **343.3 ns** |     **1.00** |    **0.03** | **0.0038** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   4,515.3 ns |    29.95 ns |    28.01 ns |   4,517.1 ns |    13.13 |    0.31 | 0.0229 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |     724.3 ns |    14.52 ns |    34.78 ns |     704.3 ns |     2.11 |    0.11 | 0.0048 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |     703.1 ns |     7.10 ns |     6.30 ns |     702.5 ns |     2.04 |    0.05 | 0.0048 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   6,120.6 ns |   122.01 ns |   240.84 ns |   6,011.4 ns |    17.79 |    0.80 | 0.0381 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |              |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **343.8 ns** |     **6.57 ns** |     **5.49 ns** |     **342.0 ns** |     **1.00** |    **0.02** | **0.0038** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 354,787.0 ns | 3,356.07 ns | 3,296.10 ns | 354,189.0 ns | 1,032.06 |   18.11 | 1.4648 | 0.4883 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,229.9 ns |    21.94 ns |    30.76 ns |   1,216.2 ns |     3.58 |    0.10 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,225.9 ns |    18.61 ns |    16.50 ns |   1,223.3 ns |     3.57 |    0.07 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 476,814.8 ns | 3,688.04 ns | 2,879.38 ns | 476,875.8 ns | 1,387.03 |   22.40 | 2.9297 | 0.9766 |  265888 B |      772.93 |
