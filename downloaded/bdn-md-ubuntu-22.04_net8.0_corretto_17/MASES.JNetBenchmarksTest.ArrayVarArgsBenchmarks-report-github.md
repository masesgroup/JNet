```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
INTEL XEON PLATINUM 8573C 2.96GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **599.9 ns** |     **7.39 ns** |     **6.17 ns** |     **1.00** |    **0.01** | **0.0038** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,306.2 ns |    67.63 ns |    63.26 ns |    12.18 |    0.16 | 0.0153 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,240.1 ns |     8.71 ns |     7.72 ns |     2.07 |    0.02 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,258.6 ns |    13.56 ns |    12.68 ns |     2.10 |    0.03 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   9,461.9 ns |    82.86 ns |    77.51 ns |    15.77 |    0.20 | 0.0305 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **595.3 ns** |     **6.39 ns** |     **5.97 ns** |     **1.00** |    **0.01** | **0.0038** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 585,878.7 ns | 5,135.99 ns | 4,804.21 ns |   984.21 |   12.36 | 0.9766 |      - |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   2,070.2 ns |    19.16 ns |    16.99 ns |     3.48 |    0.04 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   2,071.5 ns |    14.89 ns |    13.93 ns |     3.48 |    0.04 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 764,229.2 ns | 4,585.96 ns | 3,829.49 ns | 1,283.82 |   13.95 | 2.9297 | 0.9766 |  265888 B |      772.93 |
