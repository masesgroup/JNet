```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.78GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **722.8 ns** |    **14.23 ns** |    **13.31 ns** |     **1.00** |    **0.03** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   8,038.0 ns |   128.51 ns |   120.21 ns |    11.12 |    0.26 |  0.1221 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,551.9 ns |    22.52 ns |    19.97 ns |     2.15 |    0.05 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,605.5 ns |    29.01 ns |    27.14 ns |     2.22 |    0.05 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |  10,329.8 ns |    83.53 ns |    78.14 ns |    14.30 |    0.28 |  0.1984 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **753.5 ns** |     **7.80 ns** |     **7.30 ns** |     **1.00** |    **0.01** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 596,592.8 ns | 6,233.93 ns | 5,526.22 ns |   791.87 |   10.24 |  8.7891 | 1.9531 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   2,321.7 ns |    28.07 ns |    26.26 ns |     3.08 |    0.04 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   2,295.1 ns |    22.97 ns |    21.48 ns |     3.05 |    0.04 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 835,066.9 ns | 8,862.46 ns | 8,289.95 ns | 1,108.40 |   14.86 | 15.6250 | 6.8359 |  265888 B |      772.93 |
