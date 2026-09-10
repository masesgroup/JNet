```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 9V45 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **304.1 ns** |     **4.12 ns** |     **3.44 ns** |     **1.00** |    **0.02** |  **0.0186** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   3,696.3 ns |    20.61 ns |    19.27 ns |    12.16 |    0.15 |  0.1144 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |     692.5 ns |    13.72 ns |    15.25 ns |     2.28 |    0.05 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |     692.1 ns |     4.31 ns |     3.60 ns |     2.28 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   4,801.0 ns |    51.82 ns |    43.27 ns |    15.79 |    0.22 |  0.2060 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **290.7 ns** |     **2.94 ns** |     **2.75 ns** |     **1.00** |    **0.01** |  **0.0186** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 271,829.4 ns | 3,685.26 ns | 3,266.89 ns |   935.26 |   13.84 |  9.2773 | 2.9297 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,155.9 ns |    15.94 ns |    14.13 ns |     3.98 |    0.06 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,167.4 ns |    12.83 ns |    11.37 ns |     4.02 |    0.05 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 371,336.5 ns | 3,357.77 ns | 2,803.89 ns | 1,277.63 |   14.96 | 15.6250 | 7.3242 |  265856 B |      852.10 |
