```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Intel Xeon 6973P-C 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **332.3 ns** |     **5.46 ns** |     **5.11 ns** |     **1.00** |    **0.02** | **0.0038** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   4,373.3 ns |    28.53 ns |    23.83 ns |    13.16 |    0.21 | 0.0229 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |     712.0 ns |     3.06 ns |     2.71 ns |     2.14 |    0.03 | 0.0048 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |     781.4 ns |    11.67 ns |    10.35 ns |     2.35 |    0.05 | 0.0048 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   5,682.7 ns |   112.55 ns |   105.28 ns |    17.11 |    0.40 | 0.0381 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **328.8 ns** |     **3.87 ns** |     **3.80 ns** |     **1.00** |    **0.02** | **0.0038** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 355,566.6 ns | 6,935.57 ns | 8,771.28 ns | 1,081.62 |   28.72 | 1.4648 | 0.4883 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,403.0 ns |    11.50 ns |     8.98 ns |     4.27 |    0.05 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,388.8 ns |     6.83 ns |     6.06 ns |     4.22 |    0.05 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 473,941.1 ns | 7,944.23 ns | 9,148.59 ns | 1,441.71 |   31.47 | 2.9297 | 0.9766 |  265888 B |      772.93 |
