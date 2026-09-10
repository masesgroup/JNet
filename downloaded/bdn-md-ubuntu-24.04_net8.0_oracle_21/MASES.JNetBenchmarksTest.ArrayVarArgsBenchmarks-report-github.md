```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **426.4 ns** |     **2.50 ns** |     **2.34 ns** |     **1.00** |    **0.01** |  **0.0205** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   4,969.6 ns |    20.84 ns |    18.48 ns |    11.66 |    0.07 |  0.1221 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |     951.7 ns |     7.59 ns |     7.10 ns |     2.23 |    0.02 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |     962.1 ns |     3.02 ns |     2.52 ns |     2.26 |    0.01 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   6,483.5 ns |    46.24 ns |    38.61 ns |    15.21 |    0.12 |  0.2060 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **453.0 ns** |     **2.42 ns** |     **2.26 ns** |     **1.00** |    **0.01** |  **0.0205** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 367,025.4 ns | 1,875.40 ns | 1,754.25 ns |   810.25 |    5.43 |  9.2773 | 2.9297 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,543.6 ns |     5.27 ns |     4.67 ns |     3.41 |    0.02 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,562.0 ns |    13.32 ns |    12.46 ns |     3.45 |    0.03 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 523,185.3 ns | 2,793.81 ns | 2,613.33 ns | 1,154.99 |    7.91 | 15.6250 | 6.8359 |  265888 B |      772.93 |
