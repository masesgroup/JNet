```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **518.8 ns** |     **0.30 ns** |     **0.26 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   6,860.3 ns |    13.70 ns |    12.15 ns |    13.22 |    0.02 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,123.1 ns |     2.55 ns |     2.38 ns |     2.16 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,150.9 ns |     2.61 ns |     2.44 ns |     2.22 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,077.3 ns |    41.02 ns |    38.37 ns |    17.50 |    0.07 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **524.2 ns** |     **0.24 ns** |     **0.19 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 543,618.0 ns | 1,514.69 ns | 1,416.84 ns | 1,037.08 |    2.64 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,877.8 ns |     7.80 ns |     7.30 ns |     3.58 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,866.9 ns |     9.43 ns |     8.82 ns |     3.56 |    0.02 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 735,522.3 ns | 1,341.38 ns | 1,189.10 ns | 1,403.18 |    2.24 | 3.9063 | 0.9766 |  265856 B |      852.10 |
