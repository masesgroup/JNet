```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **545.9 ns** |     **5.93 ns** |     **5.25 ns** |     **1.00** |    **0.01** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   5,880.4 ns |    61.43 ns |    57.46 ns |    10.77 |    0.14 |  0.1144 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,215.8 ns |     3.22 ns |     3.01 ns |     2.23 |    0.02 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,222.5 ns |     4.85 ns |     4.54 ns |     2.24 |    0.02 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   8,550.8 ns |    93.58 ns |    87.53 ns |    15.67 |    0.21 |  0.1984 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **547.8 ns** |     **6.20 ns** |     **4.84 ns** |     **1.00** |    **0.01** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 428,226.4 ns | 3,376.12 ns | 2,819.22 ns |   781.76 |    8.36 |  9.2773 | 2.9297 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,861.0 ns |    22.62 ns |    21.16 ns |     3.40 |    0.05 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,836.7 ns |    20.98 ns |    19.62 ns |     3.35 |    0.05 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 640,405.7 ns | 9,615.06 ns | 8,993.93 ns | 1,169.11 |   18.82 | 15.6250 | 6.8359 |  265856 B |      852.10 |
