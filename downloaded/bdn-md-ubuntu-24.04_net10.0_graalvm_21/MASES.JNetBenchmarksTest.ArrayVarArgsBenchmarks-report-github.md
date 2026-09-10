```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **501.9 ns** |     **7.29 ns** |     **6.46 ns** |     **1.00** |    **0.02** | **0.0029** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   4,698.5 ns |    53.33 ns |    49.89 ns |     9.36 |    0.15 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |     723.6 ns |     7.11 ns |     6.30 ns |     1.44 |    0.02 | 0.0048 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |     947.7 ns |     8.46 ns |     7.50 ns |     1.89 |    0.03 | 0.0048 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   7,561.2 ns |   117.90 ns |   110.28 ns |    15.07 |    0.28 | 0.0381 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **364.2 ns** |     **4.26 ns** |     **3.98 ns** |     **1.00** |    **0.01** | **0.0033** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 378,507.1 ns | 2,804.00 ns | 2,622.86 ns | 1,039.37 |   13.02 | 1.4648 | 0.4883 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,263.9 ns |     8.64 ns |     7.65 ns |     3.47 |    0.04 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,294.9 ns |     8.55 ns |     7.58 ns |     3.56 |    0.04 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 634,630.3 ns | 8,201.65 ns | 7,270.55 ns | 1,742.68 |   26.68 | 2.9297 |      - |  265856 B |      852.10 |
