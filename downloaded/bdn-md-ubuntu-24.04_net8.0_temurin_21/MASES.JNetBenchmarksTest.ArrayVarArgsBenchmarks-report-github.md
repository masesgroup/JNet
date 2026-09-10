```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **605.3 ns** |     **4.19 ns** |     **3.92 ns** |     **1.00** |    **0.01** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   6,377.6 ns |    39.10 ns |    36.57 ns |    10.54 |    0.09 |  0.1221 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,285.2 ns |     8.02 ns |     6.70 ns |     2.12 |    0.02 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,345.1 ns |     4.85 ns |     4.54 ns |     2.22 |    0.02 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   9,066.7 ns |    54.70 ns |    48.49 ns |    14.98 |    0.12 |  0.1984 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **585.4 ns** |     **3.80 ns** |     **3.56 ns** |     **1.00** |    **0.01** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 486,345.8 ns | 5,551.57 ns | 4,921.32 ns |   830.82 |    9.50 |  8.7891 | 1.9531 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,929.3 ns |    11.17 ns |    10.45 ns |     3.30 |    0.03 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,950.6 ns |    23.65 ns |    22.12 ns |     3.33 |    0.04 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 711,402.4 ns | 5,684.79 ns | 5,039.42 ns | 1,215.28 |   11.01 | 15.6250 | 6.8359 |  265888 B |      772.93 |
