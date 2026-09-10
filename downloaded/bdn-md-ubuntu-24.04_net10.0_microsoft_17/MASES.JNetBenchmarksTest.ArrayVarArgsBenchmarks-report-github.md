```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.92GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **532.6 ns** |     **5.90 ns** |     **5.52 ns** |     **1.00** |    **0.01** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   6,047.5 ns |    28.66 ns |    25.41 ns |    11.35 |    0.12 |  0.1144 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,182.4 ns |     5.62 ns |     4.69 ns |     2.22 |    0.02 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,196.4 ns |     3.30 ns |     2.76 ns |     2.25 |    0.02 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   7,951.8 ns |    33.60 ns |    26.23 ns |    14.93 |    0.16 |  0.1984 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **517.0 ns** |     **3.61 ns** |     **3.20 ns** |     **1.00** |    **0.01** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 438,649.3 ns | 2,352.52 ns | 2,200.55 ns |   848.51 |    6.55 |  9.2773 | 2.9297 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,837.1 ns |     4.36 ns |     3.64 ns |     3.55 |    0.02 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,847.8 ns |     4.02 ns |     3.56 ns |     3.57 |    0.02 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 612,941.8 ns | 4,725.77 ns | 4,420.49 ns | 1,185.66 |   10.91 | 15.6250 | 6.8359 |  265856 B |      852.10 |
