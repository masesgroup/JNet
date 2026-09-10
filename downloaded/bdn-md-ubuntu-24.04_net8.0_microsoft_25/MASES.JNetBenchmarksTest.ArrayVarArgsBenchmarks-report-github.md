```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **577.9 ns** |     **5.24 ns** |     **4.90 ns** |     **1.00** |    **0.01** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   6,528.1 ns |    40.12 ns |    37.53 ns |    11.30 |    0.11 |  0.1221 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,349.4 ns |     5.99 ns |     5.31 ns |     2.34 |    0.02 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,345.6 ns |    11.24 ns |    10.52 ns |     2.33 |    0.03 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   8,826.7 ns |   103.53 ns |    96.84 ns |    15.27 |    0.21 |  0.1984 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **599.2 ns** |     **7.71 ns** |     **6.83 ns** |     **1.00** |    **0.02** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 487,304.9 ns | 1,540.34 ns | 1,365.47 ns |   813.38 |    9.16 |  9.2773 | 2.9297 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,986.6 ns |    16.53 ns |    15.46 ns |     3.32 |    0.04 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,962.2 ns |    16.51 ns |    15.45 ns |     3.28 |    0.04 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 702,904.1 ns | 6,083.54 ns | 5,392.90 ns | 1,173.24 |   15.50 | 15.6250 | 6.8359 |  265888 B |      772.93 |
