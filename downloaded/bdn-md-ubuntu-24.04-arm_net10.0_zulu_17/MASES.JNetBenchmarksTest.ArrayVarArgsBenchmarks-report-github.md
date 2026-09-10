```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **548.1 ns** |     **0.47 ns** |     **0.39 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,308.9 ns |    20.62 ns |    18.28 ns |    13.34 |    0.03 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,257.6 ns |    11.49 ns |    10.75 ns |     2.29 |    0.02 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,286.0 ns |    14.68 ns |    13.73 ns |     2.35 |    0.02 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,685.1 ns |    39.08 ns |    34.64 ns |    17.67 |    0.06 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **559.3 ns** |     **0.73 ns** |     **0.65 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 556,906.2 ns | 1,139.11 ns | 1,065.52 ns |   995.69 |    2.16 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,886.3 ns |     6.89 ns |     6.45 ns |     3.37 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,924.4 ns |    12.35 ns |    11.55 ns |     3.44 |    0.02 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 753,371.1 ns |   534.37 ns |   473.71 ns | 1,346.95 |    1.72 | 3.9063 | 0.9766 |  265856 B |      852.10 |
