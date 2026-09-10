```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Intel Xeon 6973P-C 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Median       | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|-------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **350.0 ns** |     **2.04 ns** |     **1.91 ns** |     **350.0 ns** |     **1.00** |    **0.01** | **0.0038** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   4,782.1 ns |    88.06 ns |    78.06 ns |   4,749.1 ns |    13.66 |    0.23 | 0.0229 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |     795.8 ns |     8.14 ns |     7.61 ns |     794.8 ns |     2.27 |    0.02 | 0.0048 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |     796.4 ns |     9.87 ns |     8.24 ns |     795.1 ns |     2.28 |    0.03 | 0.0048 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   6,340.9 ns |    48.69 ns |    54.12 ns |   6,351.1 ns |    18.12 |    0.18 | 0.0381 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |              |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **364.0 ns** |     **6.62 ns** |     **6.19 ns** |     **362.1 ns** |     **1.00** |    **0.02** | **0.0038** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 380,489.7 ns | 3,899.52 ns | 3,256.27 ns | 380,866.0 ns | 1,045.71 |   19.04 | 1.4648 | 0.4883 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,402.7 ns |    10.00 ns |     7.80 ns |   1,401.9 ns |     3.86 |    0.07 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,470.8 ns |    29.45 ns |    65.87 ns |   1,435.0 ns |     4.04 |    0.19 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 496,034.6 ns | 4,970.58 ns | 4,649.48 ns | 497,137.6 ns | 1,363.26 |   25.35 | 2.9297 | 0.9766 |  265888 B |      772.93 |
