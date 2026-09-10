```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **526.7 ns** |     **0.41 ns** |     **0.34 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   6,843.3 ns |    10.31 ns |     9.14 ns |    12.99 |    0.02 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,110.1 ns |     1.38 ns |     1.22 ns |     2.11 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,113.5 ns |     1.63 ns |     1.52 ns |     2.11 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   8,904.0 ns |    24.62 ns |    21.83 ns |    16.91 |    0.04 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **535.3 ns** |     **0.40 ns** |     **0.34 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 543,739.2 ns | 1,141.70 ns | 1,012.09 ns | 1,015.73 |    1.93 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,868.2 ns |     4.74 ns |     3.96 ns |     3.49 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,870.9 ns |    14.39 ns |    13.46 ns |     3.49 |    0.02 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 731,668.3 ns | 1,130.98 ns | 1,002.58 ns | 1,366.79 |    1.99 | 3.9063 | 0.9766 |  265856 B |      852.10 |
