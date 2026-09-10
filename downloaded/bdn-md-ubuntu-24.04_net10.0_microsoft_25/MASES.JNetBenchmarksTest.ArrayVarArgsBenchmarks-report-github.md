```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error        | StdDev       | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|-------------:|-------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **419.8 ns** |      **7.25 ns** |      **6.78 ns** |     **1.00** |    **0.02** | **0.0033** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   5,212.2 ns |     89.84 ns |     84.04 ns |    12.42 |    0.27 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |     798.6 ns |     14.75 ns |     13.79 ns |     1.90 |    0.04 | 0.0048 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |     803.5 ns |     13.04 ns |     11.56 ns |     1.91 |    0.04 | 0.0048 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   8,009.1 ns |    145.08 ns |    135.71 ns |    19.08 |    0.43 | 0.0305 |      - |    3488 B |       11.18 |
|                             |        |              |              |              |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **393.9 ns** |      **6.14 ns** |      **5.13 ns** |     **1.00** |    **0.02** | **0.0033** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 396,868.6 ns |  4,367.65 ns |  3,871.80 ns | 1,007.62 |   15.73 | 1.4648 | 0.4883 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,521.9 ns |     23.73 ns |     21.04 ns |     3.86 |    0.07 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,557.2 ns |     15.11 ns |     12.61 ns |     3.95 |    0.06 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 681,649.0 ns | 13,427.70 ns | 13,789.26 ns | 1,730.66 |   40.28 | 2.9297 |      - |  265856 B |      852.10 |
