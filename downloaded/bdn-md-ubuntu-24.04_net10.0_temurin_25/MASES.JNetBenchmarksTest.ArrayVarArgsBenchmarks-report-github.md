```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 3.69GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **375.5 ns** |     **2.99 ns** |     **2.65 ns** |     **1.00** |    **0.01** |  **0.0186** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   4,216.7 ns |    20.84 ns |    19.50 ns |    11.23 |    0.09 |  0.1144 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |     872.2 ns |     6.79 ns |     6.02 ns |     2.32 |    0.02 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |     886.8 ns |     2.46 ns |     2.05 ns |     2.36 |    0.02 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   6,167.1 ns |    34.06 ns |    31.86 ns |    16.42 |    0.14 |  0.2060 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **387.2 ns** |     **2.04 ns** |     **1.91 ns** |     **1.00** |    **0.01** |  **0.0186** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 328,410.3 ns | 1,483.12 ns | 1,314.75 ns |   848.10 |    5.21 |  9.2773 | 2.9297 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,489.0 ns |    12.53 ns |    11.11 ns |     3.85 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,492.8 ns |     7.94 ns |     7.03 ns |     3.86 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 483,010.2 ns | 2,655.21 ns | 2,483.68 ns | 1,247.35 |    8.60 | 15.6250 | 7.3242 |  265856 B |      852.10 |
