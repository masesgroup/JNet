```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **407.6 ns** |     **3.90 ns** |     **3.65 ns** |     **1.00** |    **0.01** |  **0.0186** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   4,530.1 ns |    44.82 ns |    41.92 ns |    11.11 |    0.14 |  0.1144 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |     922.9 ns |     7.29 ns |     6.46 ns |     2.26 |    0.02 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |     923.3 ns |     4.83 ns |     4.52 ns |     2.27 |    0.02 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   6,053.3 ns |    91.81 ns |    81.39 ns |    14.85 |    0.23 |  0.2060 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **383.9 ns** |     **4.84 ns** |     **4.53 ns** |     **1.00** |    **0.02** |  **0.0186** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 340,705.9 ns | 2,531.86 ns | 2,368.30 ns |   887.56 |   11.79 |  9.2773 | 2.9297 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,514.4 ns |     7.60 ns |     6.74 ns |     3.95 |    0.05 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,508.7 ns |     5.09 ns |     4.51 ns |     3.93 |    0.05 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 472,687.9 ns | 3,972.76 ns | 3,716.12 ns | 1,231.38 |   16.93 | 15.6250 | 7.3242 |  265856 B |      852.10 |
