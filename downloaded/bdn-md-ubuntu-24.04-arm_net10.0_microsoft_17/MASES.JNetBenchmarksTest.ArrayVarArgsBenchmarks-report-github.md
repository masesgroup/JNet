```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error     | StdDev    | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|----------:|----------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **543.3 ns** |   **0.42 ns** |   **0.37 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,070.0 ns |  12.00 ns |  10.63 ns |    13.01 |    0.02 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,118.6 ns |   1.90 ns |   1.77 ns |     2.06 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,115.7 ns |   1.85 ns |   1.73 ns |     2.05 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,210.9 ns |  38.36 ns |  35.89 ns |    16.95 |    0.06 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |           |           |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **529.8 ns** |   **0.34 ns** |   **0.30 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 540,516.1 ns | 843.45 ns | 788.97 ns | 1,020.26 |    1.55 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,849.5 ns |   1.91 ns |   1.69 ns |     3.49 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,856.4 ns |   4.64 ns |   4.34 ns |     3.50 |    0.01 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 735,897.1 ns | 566.55 ns | 502.23 ns | 1,389.06 |    1.19 | 3.9063 | 0.9766 |  265856 B |      852.10 |
