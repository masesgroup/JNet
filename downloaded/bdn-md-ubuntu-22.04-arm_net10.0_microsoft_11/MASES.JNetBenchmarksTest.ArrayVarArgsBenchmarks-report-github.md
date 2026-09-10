```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **554.3 ns** |     **0.24 ns** |     **0.22 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,181.1 ns |    16.99 ns |    15.89 ns |    12.96 |    0.03 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,144.9 ns |     2.86 ns |     2.68 ns |     2.07 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,165.2 ns |     1.34 ns |     1.05 ns |     2.10 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,831.9 ns |    41.59 ns |    36.87 ns |    17.74 |    0.06 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **550.5 ns** |     **0.40 ns** |     **0.35 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 563,807.7 ns | 1,478.56 ns | 1,383.05 ns | 1,024.19 |    2.52 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,916.8 ns |     7.42 ns |     6.94 ns |     3.48 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,873.0 ns |     7.51 ns |     7.02 ns |     3.40 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 742,426.8 ns | 1,976.40 ns | 1,848.73 ns | 1,348.66 |    3.36 | 3.9063 | 0.9766 |  265856 B |      852.10 |
