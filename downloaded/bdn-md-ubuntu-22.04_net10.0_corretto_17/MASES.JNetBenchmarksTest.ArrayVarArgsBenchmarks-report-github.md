```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.69GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error        | StdDev       | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|-------------:|-------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **665.9 ns** |     **11.20 ns** |     **10.48 ns** |     **1.00** |    **0.02** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,733.5 ns |     69.66 ns |     58.17 ns |    11.62 |    0.20 |  0.1068 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,489.4 ns |     14.37 ns |     13.44 ns |     2.24 |    0.04 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,524.9 ns |     19.98 ns |     17.71 ns |     2.29 |    0.04 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |  10,049.1 ns |     64.36 ns |     57.05 ns |    15.09 |    0.25 |  0.1984 |      - |    3488 B |       11.18 |
|                             |        |              |              |              |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **685.9 ns** |     **11.97 ns** |     **11.20 ns** |     **1.00** |    **0.02** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 593,751.1 ns |  5,242.91 ns |  4,647.70 ns |   865.91 |   15.03 |  8.7891 | 1.9531 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   2,173.5 ns |     16.65 ns |     15.58 ns |     3.17 |    0.05 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   2,206.1 ns |     25.19 ns |     22.33 ns |     3.22 |    0.06 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 782,376.6 ns | 14,454.00 ns | 13,520.28 ns | 1,140.99 |   26.13 | 15.6250 | 6.8359 |  265856 B |      852.10 |
