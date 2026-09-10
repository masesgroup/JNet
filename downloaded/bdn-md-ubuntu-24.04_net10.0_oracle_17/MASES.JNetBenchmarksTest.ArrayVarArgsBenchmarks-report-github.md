```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **532.5 ns** |     **7.77 ns** |     **7.27 ns** |     **1.00** |    **0.02** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   6,352.2 ns |    72.44 ns |    67.76 ns |    11.93 |    0.20 |  0.1144 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,201.9 ns |     7.22 ns |     6.03 ns |     2.26 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,223.4 ns |     6.14 ns |     5.45 ns |     2.30 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   7,981.1 ns |    63.99 ns |    59.86 ns |    14.99 |    0.23 |  0.1984 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **540.0 ns** |     **6.27 ns** |     **5.87 ns** |     **1.00** |    **0.01** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 468,490.2 ns | 3,013.48 ns | 2,818.81 ns |   867.63 |   10.48 |  9.2773 | 2.9297 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,880.5 ns |    10.25 ns |     9.59 ns |     3.48 |    0.04 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,855.7 ns |    12.22 ns |    10.83 ns |     3.44 |    0.04 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 657,926.6 ns | 5,764.17 ns | 5,391.81 ns | 1,218.45 |   16.11 | 15.6250 | 6.8359 |  265856 B |      852.10 |
