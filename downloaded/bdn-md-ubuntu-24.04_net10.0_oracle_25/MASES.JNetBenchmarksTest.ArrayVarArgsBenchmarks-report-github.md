```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 9V45 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **274.7 ns** |     **3.32 ns** |     **2.77 ns** |     **1.00** |    **0.01** |  **0.0186** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   3,723.7 ns |    66.22 ns |    61.94 ns |    13.56 |    0.26 |  0.1183 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |     679.2 ns |    10.27 ns |     8.58 ns |     2.47 |    0.04 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |     686.0 ns |     7.60 ns |     6.73 ns |     2.50 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   4,827.0 ns |    73.05 ns |    68.33 ns |    17.57 |    0.30 |  0.2060 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **290.2 ns** |     **3.83 ns** |     **2.99 ns** |     **1.00** |    **0.01** |  **0.0186** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 273,222.7 ns | 2,026.79 ns | 1,692.46 ns |   941.45 |   10.87 |  9.2773 | 2.9297 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,135.3 ns |    16.15 ns |    14.32 ns |     3.91 |    0.06 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,132.1 ns |    11.46 ns |    10.72 ns |     3.90 |    0.05 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 368,261.7 ns | 3,492.32 ns | 2,726.57 ns | 1,268.92 |   15.46 | 15.6250 | 7.3242 |  265856 B |      852.10 |
