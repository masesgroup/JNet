```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **560.2 ns** |     **0.65 ns** |     **0.57 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,444.2 ns |    24.35 ns |    22.77 ns |    13.29 |    0.04 | 0.0153 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,145.8 ns |     1.71 ns |     1.60 ns |     2.05 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,196.1 ns |     3.58 ns |     3.17 ns |     2.14 |    0.01 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,095.7 ns |    37.16 ns |    34.76 ns |    16.24 |    0.06 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **562.0 ns** |     **0.23 ns** |     **0.21 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 569,279.1 ns | 1,065.31 ns |   996.49 ns | 1,012.95 |    1.75 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,896.5 ns |     3.86 ns |     3.22 ns |     3.37 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,935.0 ns |    11.78 ns |    11.02 ns |     3.44 |    0.02 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 738,514.1 ns | 1,439.79 ns | 1,202.29 ns | 1,314.08 |    2.11 | 3.9063 | 0.9766 |  265856 B |      852.10 |
