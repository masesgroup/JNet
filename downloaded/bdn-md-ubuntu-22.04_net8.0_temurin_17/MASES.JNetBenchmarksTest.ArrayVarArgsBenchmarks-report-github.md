```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.65GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **720.9 ns** |    **13.22 ns** |    **12.36 ns** |     **1.00** |    **0.02** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   8,031.7 ns |    89.15 ns |    83.39 ns |    11.14 |    0.21 |  0.1221 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,629.6 ns |    13.27 ns |    11.76 ns |     2.26 |    0.04 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,610.5 ns |    11.68 ns |    10.93 ns |     2.23 |    0.04 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |  10,664.4 ns |    45.00 ns |    35.13 ns |    14.80 |    0.25 |  0.1984 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **735.3 ns** |     **8.90 ns** |     **8.32 ns** |     **1.00** |    **0.02** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 603,504.0 ns | 7,898.86 ns | 7,388.60 ns |   820.82 |   13.26 |  8.7891 | 1.9531 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   2,340.8 ns |    24.84 ns |    22.02 ns |     3.18 |    0.05 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   2,319.5 ns |    21.44 ns |    17.91 ns |     3.15 |    0.04 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 848,678.0 ns | 8,735.93 ns | 7,744.18 ns | 1,154.28 |   16.25 | 15.6250 | 6.8359 |  265888 B |      772.93 |
