```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error     | StdDev    | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|----------:|----------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **544.3 ns** |   **0.52 ns** |   **0.46 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,044.1 ns |   6.47 ns |   5.73 ns |    12.94 |    0.01 | 0.0305 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,187.7 ns |   2.20 ns |   1.95 ns |     2.18 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,199.9 ns |   1.08 ns |   0.95 ns |     2.20 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   9,017.7 ns |  24.63 ns |  21.83 ns |    16.57 |    0.04 | 0.0458 |      - |    3520 B |       10.23 |
|                             |        |              |           |           |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **535.4 ns** |   **0.13 ns** |   **0.11 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 562,374.9 ns | 710.62 ns | 629.94 ns | 1,050.45 |    1.16 | 1.9531 |      - |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,740.6 ns |   6.86 ns |   6.41 ns |     3.25 |    0.01 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,741.4 ns |   6.67 ns |   6.23 ns |     3.25 |    0.01 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 749,158.4 ns | 661.73 ns | 586.61 ns | 1,399.35 |    1.09 | 3.9063 | 0.9766 |  265888 B |      772.93 |
