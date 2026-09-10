```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **590.4 ns** |     **6.60 ns** |     **6.17 ns** |     **1.00** |    **0.01** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   6,392.3 ns |    66.05 ns |    61.78 ns |    10.83 |    0.15 |  0.1221 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,301.0 ns |     3.58 ns |     2.79 ns |     2.20 |    0.02 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,312.2 ns |     6.23 ns |     4.86 ns |     2.22 |    0.02 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   8,644.5 ns |    54.21 ns |    50.71 ns |    14.64 |    0.17 |  0.1984 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **603.7 ns** |     **5.32 ns** |     **4.72 ns** |     **1.00** |    **0.01** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 480,321.8 ns | 3,763.25 ns | 3,520.14 ns |   795.63 |    8.29 |  9.2773 | 2.9297 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,906.5 ns |     7.70 ns |     6.82 ns |     3.16 |    0.03 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,914.8 ns |    11.22 ns |     9.94 ns |     3.17 |    0.03 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 706,669.4 ns | 3,890.09 ns | 3,248.40 ns | 1,170.57 |   10.33 | 15.6250 | 6.8359 |  265888 B |      772.93 |
