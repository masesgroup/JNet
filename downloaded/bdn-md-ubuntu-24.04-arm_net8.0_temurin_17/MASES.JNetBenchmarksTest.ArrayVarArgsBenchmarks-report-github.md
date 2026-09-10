```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error     | StdDev    | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|----------:|----------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **540.6 ns** |   **0.36 ns** |   **0.32 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,292.9 ns |   7.69 ns |   6.42 ns |    13.49 |    0.01 | 0.0305 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,181.3 ns |   1.16 ns |   0.97 ns |     2.18 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,194.8 ns |   1.55 ns |   1.45 ns |     2.21 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   9,523.6 ns |  40.27 ns |  37.67 ns |    17.62 |    0.07 | 0.0458 |      - |    3520 B |       10.23 |
|                             |        |              |           |           |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **534.6 ns** |   **0.31 ns** |   **0.28 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 580,336.7 ns | 993.12 ns | 928.97 ns | 1,085.56 |    1.77 | 1.9531 |      - |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,916.2 ns |   5.95 ns |   5.56 ns |     3.58 |    0.01 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,897.9 ns |   9.89 ns |   9.25 ns |     3.55 |    0.02 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 781,265.7 ns | 357.39 ns | 279.02 ns | 1,461.42 |    0.88 | 3.9063 | 0.9766 |  265888 B |      772.93 |
