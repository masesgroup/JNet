```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **556.6 ns** |     **0.49 ns** |     **0.44 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,488.0 ns |    29.06 ns |    25.76 ns |    13.45 |    0.05 | 0.0153 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,152.5 ns |     1.60 ns |     1.42 ns |     2.07 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,163.9 ns |     1.28 ns |     1.14 ns |     2.09 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,314.6 ns |    32.84 ns |    30.72 ns |    16.74 |    0.05 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **544.0 ns** |     **0.37 ns** |     **0.31 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 568,682.5 ns | 1,244.71 ns | 1,164.30 ns | 1,045.37 |    2.15 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,854.2 ns |    11.34 ns |    10.60 ns |     3.41 |    0.02 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,855.5 ns |     3.69 ns |     3.27 ns |     3.41 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 751,240.1 ns | 1,229.78 ns | 1,026.92 ns | 1,380.95 |    1.97 | 3.9063 | 0.9766 |  265856 B |      852.10 |
