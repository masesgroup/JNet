```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **400.1 ns** |     **3.40 ns** |     **3.18 ns** |     **1.00** |    **0.01** | **0.0033** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   5,241.5 ns |    60.64 ns |    56.73 ns |    13.10 |    0.17 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |     837.0 ns |     7.45 ns |     6.96 ns |     2.09 |    0.02 | 0.0048 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |     833.6 ns |     4.76 ns |     4.45 ns |     2.08 |    0.02 | 0.0048 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   8,068.2 ns |    71.39 ns |    63.29 ns |    20.17 |    0.22 | 0.0305 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **394.0 ns** |     **3.35 ns** |     **3.14 ns** |     **1.00** |    **0.01** | **0.0033** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 421,104.3 ns | 2,839.41 ns | 2,517.07 ns | 1,068.89 |   10.31 | 1.4648 | 0.4883 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,579.9 ns |    12.56 ns |    11.75 ns |     4.01 |    0.04 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,576.4 ns |    10.14 ns |     9.49 ns |     4.00 |    0.04 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 689,758.5 ns | 3,095.47 ns | 2,744.06 ns | 1,750.81 |   15.10 | 2.9297 |      - |  265856 B |      852.10 |
