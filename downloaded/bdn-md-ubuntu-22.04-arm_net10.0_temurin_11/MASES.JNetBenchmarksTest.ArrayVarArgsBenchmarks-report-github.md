```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **561.5 ns** |     **0.65 ns** |     **0.57 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,144.9 ns |    11.86 ns |     9.90 ns |    12.72 |    0.02 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,157.8 ns |     3.03 ns |     2.83 ns |     2.06 |    0.01 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,164.8 ns |     4.76 ns |     4.45 ns |     2.07 |    0.01 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   8,970.8 ns |    21.99 ns |    19.49 ns |    15.98 |    0.04 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **559.4 ns** |     **0.41 ns** |     **0.36 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 581,560.2 ns | 1,201.95 ns | 1,124.31 ns | 1,039.61 |    2.05 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,966.2 ns |     9.39 ns |     8.79 ns |     3.51 |    0.02 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,975.8 ns |     9.86 ns |     9.23 ns |     3.53 |    0.02 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 752,792.0 ns |   642.53 ns |   536.54 ns | 1,345.71 |    1.25 | 3.9063 | 0.9766 |  265856 B |      852.10 |
