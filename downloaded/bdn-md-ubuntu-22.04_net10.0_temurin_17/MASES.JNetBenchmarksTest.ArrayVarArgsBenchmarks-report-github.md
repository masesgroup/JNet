```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 3.19GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **659.8 ns** |     **9.91 ns** |     **9.27 ns** |     **1.00** |    **0.02** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,488.9 ns |    56.85 ns |    50.40 ns |    11.35 |    0.17 |  0.1068 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,471.8 ns |    18.56 ns |    17.36 ns |     2.23 |    0.04 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,480.9 ns |    19.02 ns |    17.79 ns |     2.24 |    0.04 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,430.3 ns |    49.64 ns |    38.76 ns |    14.30 |    0.20 |  0.1984 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **698.8 ns** |    **13.88 ns** |    **12.98 ns** |     **1.00** |    **0.03** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 574,451.0 ns | 5,777.28 ns | 5,404.07 ns |   822.28 |   16.58 |  8.7891 | 1.9531 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   2,246.2 ns |    26.26 ns |    24.56 ns |     3.22 |    0.07 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   2,184.2 ns |    19.50 ns |    18.24 ns |     3.13 |    0.06 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 753,520.8 ns | 8,539.61 ns | 7,987.95 ns | 1,078.60 |   22.34 | 15.6250 | 6.8359 |  265856 B |      852.10 |
