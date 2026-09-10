```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 3.65GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **469.4 ns** |     **8.12 ns** |     **7.60 ns** |     **1.00** |    **0.02** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   5,367.9 ns |    70.04 ns |    65.51 ns |    11.44 |    0.22 |  0.1144 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,073.5 ns |     8.70 ns |     7.71 ns |     2.29 |    0.04 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,077.4 ns |    13.47 ns |    12.60 ns |     2.30 |    0.04 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   7,190.7 ns |    71.12 ns |    66.53 ns |    15.32 |    0.28 |  0.2060 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **470.7 ns** |     **9.24 ns** |     **8.64 ns** |     **1.00** |    **0.03** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 402,256.1 ns | 3,218.30 ns | 2,687.43 ns |   854.87 |   16.01 |  9.2773 | 2.9297 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,797.1 ns |     9.07 ns |     8.04 ns |     3.82 |    0.07 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,769.2 ns |     8.68 ns |     7.69 ns |     3.76 |    0.07 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 556,735.0 ns | 7,493.73 ns | 7,009.64 ns | 1,183.17 |   25.31 | 15.6250 | 6.8359 |  265856 B |      852.10 |
