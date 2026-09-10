```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **377.4 ns** |     **3.55 ns** |     **3.32 ns** |     **1.00** |    **0.01** | **0.0033** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   5,248.3 ns |    29.74 ns |    27.82 ns |    13.91 |    0.14 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |     791.7 ns |     5.84 ns |     5.17 ns |     2.10 |    0.02 | 0.0048 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |     801.9 ns |     4.00 ns |     3.55 ns |     2.13 |    0.02 | 0.0048 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   7,886.8 ns |    91.84 ns |    81.42 ns |    20.90 |    0.27 | 0.0305 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **380.6 ns** |     **2.78 ns** |     **2.60 ns** |     **1.00** |    **0.01** | **0.0033** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 416,077.6 ns | 1,469.43 ns | 1,374.50 ns | 1,093.19 |    8.03 | 1.4648 | 0.4883 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,547.7 ns |     8.72 ns |     7.28 ns |     4.07 |    0.03 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,553.1 ns |    10.36 ns |     9.69 ns |     4.08 |    0.04 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 667,371.8 ns | 7,265.88 ns | 6,441.01 ns | 1,753.43 |   20.04 | 2.9297 |      - |  265856 B |      852.10 |
