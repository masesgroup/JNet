```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **704.6 ns** |     **9.90 ns** |     **9.26 ns** |     **1.00** |    **0.02** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,853.7 ns |    81.52 ns |    72.27 ns |    11.15 |    0.17 |  0.1068 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,452.8 ns |     9.57 ns |     8.48 ns |     2.06 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,467.5 ns |    17.62 ns |    16.49 ns |     2.08 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,879.0 ns |   102.92 ns |    85.94 ns |    14.02 |    0.21 |  0.1984 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **676.5 ns** |    **10.40 ns** |     **9.73 ns** |     **1.00** |    **0.02** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 612,520.3 ns | 7,014.74 ns | 6,218.39 ns |   905.54 |   15.34 |  8.7891 | 1.9531 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   2,203.0 ns |    13.75 ns |    12.87 ns |     3.26 |    0.05 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   2,178.6 ns |    20.94 ns |    19.58 ns |     3.22 |    0.05 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 772,059.5 ns | 9,128.52 ns | 8,092.19 ns | 1,141.40 |   19.55 | 15.6250 | 6.8359 |  265856 B |      852.10 |
