```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Intel Xeon Platinum 8370C CPU 2.80GHz (Max: 3.33GHz), 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **658.6 ns** |     **8.74 ns** |     **8.17 ns** |     **1.00** |    **0.02** | **0.0124** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,796.5 ns |    89.31 ns |    83.55 ns |    11.84 |    0.19 | 0.0763 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,403.7 ns |    12.47 ns |    11.05 ns |     2.13 |    0.03 | 0.0153 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,437.4 ns |    14.07 ns |    13.16 ns |     2.18 |    0.03 | 0.0153 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,810.1 ns |   100.73 ns |    94.23 ns |    14.90 |    0.23 | 0.1373 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **623.6 ns** |     **5.79 ns** |     **5.41 ns** |     **1.00** |    **0.01** | **0.0124** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 590,552.8 ns | 4,610.11 ns | 3,849.65 ns |   947.13 |    9.91 | 5.8594 | 1.9531 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   2,188.8 ns |    24.46 ns |    20.42 ns |     3.51 |    0.04 | 0.0153 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   2,224.0 ns |    32.84 ns |    30.72 ns |     3.57 |    0.06 | 0.0153 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 776,680.4 ns | 5,791.71 ns | 5,134.20 ns | 1,245.64 |   13.11 | 9.7656 | 2.9297 |  265856 B |      852.10 |
