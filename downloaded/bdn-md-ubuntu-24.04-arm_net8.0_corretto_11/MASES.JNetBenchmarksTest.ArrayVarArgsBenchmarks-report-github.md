```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **529.4 ns** |     **0.24 ns** |     **0.20 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,362.0 ns |    22.28 ns |    19.75 ns |    13.91 |    0.04 | 0.0305 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,213.3 ns |     1.96 ns |     1.74 ns |     2.29 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,199.1 ns |     2.20 ns |     2.06 ns |     2.27 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   9,197.7 ns |    18.41 ns |    17.22 ns |    17.37 |    0.03 | 0.0458 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **528.7 ns** |     **0.39 ns** |     **0.35 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 583,498.2 ns | 1,235.87 ns | 1,095.57 ns | 1,103.70 |    2.12 | 1.9531 |      - |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,952.7 ns |     7.61 ns |     7.12 ns |     3.69 |    0.01 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,947.9 ns |     7.13 ns |     5.95 ns |     3.68 |    0.01 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 770,865.3 ns |   737.23 ns |   653.54 ns | 1,458.12 |    1.51 | 3.9063 | 0.9766 |  265888 B |      772.93 |
