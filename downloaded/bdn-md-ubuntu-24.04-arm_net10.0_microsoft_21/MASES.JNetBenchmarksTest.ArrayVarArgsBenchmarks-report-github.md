```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **531.2 ns** |     **0.51 ns** |     **0.45 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   6,920.4 ns |    23.98 ns |    22.43 ns |    13.03 |    0.04 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,116.2 ns |     1.13 ns |     0.88 ns |     2.10 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,142.4 ns |     1.53 ns |     1.35 ns |     2.15 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   8,867.8 ns |    33.30 ns |    31.15 ns |    16.69 |    0.06 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **526.0 ns** |     **0.31 ns** |     **0.28 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 540,870.5 ns |   742.43 ns |   694.47 ns | 1,028.26 |    1.38 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,829.1 ns |    10.86 ns |    10.16 ns |     3.48 |    0.02 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,838.0 ns |     3.92 ns |     3.47 ns |     3.49 |    0.01 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 723,459.4 ns | 1,469.11 ns | 1,226.78 ns | 1,375.38 |    2.35 | 3.9063 | 0.9766 |  265856 B |      852.10 |
