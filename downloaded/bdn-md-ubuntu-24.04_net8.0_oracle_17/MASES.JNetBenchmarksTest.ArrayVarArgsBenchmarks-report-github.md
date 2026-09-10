```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **606.0 ns** |     **3.63 ns** |     **3.39 ns** |     **1.00** |    **0.01** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   6,898.3 ns |    26.64 ns |    24.92 ns |    11.38 |    0.07 |  0.1221 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,310.3 ns |     7.47 ns |     6.62 ns |     2.16 |    0.02 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,304.7 ns |     5.48 ns |     4.57 ns |     2.15 |    0.01 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   8,876.9 ns |    72.34 ns |    67.67 ns |    14.65 |    0.13 |  0.1984 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **602.5 ns** |     **5.35 ns** |     **5.00 ns** |     **1.00** |    **0.01** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 505,759.3 ns | 3,440.83 ns | 3,218.55 ns |   839.50 |    8.49 |  8.7891 | 1.9531 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,980.3 ns |    11.85 ns |    10.51 ns |     3.29 |    0.03 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,982.8 ns |    13.43 ns |    11.91 ns |     3.29 |    0.03 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 702,183.7 ns | 3,199.47 ns | 2,836.25 ns | 1,165.54 |   10.40 | 15.6250 | 6.8359 |  265888 B |      772.93 |
