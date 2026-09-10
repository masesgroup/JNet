```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.58GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **695.0 ns** |     **9.57 ns** |     **8.95 ns** |     **1.00** |    **0.02** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   8,067.9 ns |   105.56 ns |    98.75 ns |    11.61 |    0.20 |  0.1068 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,527.0 ns |    15.18 ns |    13.45 ns |     2.20 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,561.1 ns |    24.01 ns |    22.46 ns |     2.25 |    0.04 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |  10,187.9 ns |    63.45 ns |    52.99 ns |    14.66 |    0.20 |  0.1984 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **683.7 ns** |     **5.70 ns** |     **5.05 ns** |     **1.00** |    **0.01** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 620,886.3 ns | 7,714.51 ns | 6,838.71 ns |   908.15 |   11.63 |  8.7891 | 1.9531 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   2,238.0 ns |    18.72 ns |    17.51 ns |     3.27 |    0.03 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   2,254.5 ns |    14.77 ns |    13.82 ns |     3.30 |    0.03 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 795,068.2 ns | 8,096.84 ns | 7,177.63 ns | 1,162.92 |   13.09 | 15.6250 | 6.8359 |  265856 B |      852.10 |
