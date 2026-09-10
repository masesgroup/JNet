```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **545.6 ns** |     **0.35 ns** |     **0.29 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,166.8 ns |    17.85 ns |    15.82 ns |    13.14 |    0.03 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,199.5 ns |     9.73 ns |     9.10 ns |     2.20 |    0.02 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,181.9 ns |     2.14 ns |     1.79 ns |     2.17 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,676.3 ns |    54.39 ns |    48.21 ns |    17.74 |    0.09 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **546.6 ns** |     **0.52 ns** |     **0.43 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 561,912.2 ns | 1,312.35 ns | 1,163.37 ns | 1,027.99 |    2.20 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,853.5 ns |    10.02 ns |     9.37 ns |     3.39 |    0.02 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,878.6 ns |     6.59 ns |     6.17 ns |     3.44 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 755,770.8 ns | 1,508.62 ns | 1,259.77 ns | 1,382.64 |    2.46 | 3.9063 | 0.9766 |  265856 B |      852.10 |
