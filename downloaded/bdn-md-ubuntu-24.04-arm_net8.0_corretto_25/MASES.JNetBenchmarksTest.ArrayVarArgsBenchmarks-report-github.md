```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **541.5 ns** |     **0.82 ns** |     **0.72 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,254.2 ns |     6.23 ns |     5.52 ns |    13.40 |    0.02 | 0.0305 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,205.5 ns |     1.32 ns |     1.11 ns |     2.23 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,210.2 ns |     1.75 ns |     1.55 ns |     2.23 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   9,437.8 ns |    47.34 ns |    44.28 ns |    17.43 |    0.08 | 0.0458 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **540.2 ns** |     **0.19 ns** |     **0.14 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 572,478.7 ns | 1,225.52 ns | 1,146.36 ns | 1,059.70 |    2.07 | 1.9531 |      - |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,915.3 ns |     5.05 ns |     4.72 ns |     3.55 |    0.01 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,918.8 ns |     6.32 ns |     5.91 ns |     3.55 |    0.01 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 767,772.8 ns | 1,577.03 ns | 1,316.89 ns | 1,421.21 |    2.38 | 3.9063 | 0.9766 |  265888 B |      772.93 |
