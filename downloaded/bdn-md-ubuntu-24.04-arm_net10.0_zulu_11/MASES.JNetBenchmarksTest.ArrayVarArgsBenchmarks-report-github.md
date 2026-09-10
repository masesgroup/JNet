```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev    | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|----------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **558.5 ns** |     **0.30 ns** |   **0.27 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   6,961.9 ns |    12.44 ns |  11.03 ns |    12.47 |    0.02 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,154.9 ns |     2.61 ns |   2.44 ns |     2.07 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,170.7 ns |     3.48 ns |   3.25 ns |     2.10 |    0.01 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,181.3 ns |    24.88 ns |  23.27 ns |    16.44 |    0.04 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |             |           |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **550.5 ns** |     **0.37 ns** |   **0.33 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 563,621.4 ns | 1,078.61 ns | 956.16 ns | 1,023.76 |    1.78 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,929.4 ns |     5.34 ns |   4.73 ns |     3.50 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,916.7 ns |     5.05 ns |   4.22 ns |     3.48 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 762,494.1 ns |   590.29 ns | 492.92 ns | 1,384.99 |    1.18 | 3.9063 | 0.9766 |  265856 B |      852.10 |
