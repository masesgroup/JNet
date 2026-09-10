```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.70GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error        | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|-------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **669.9 ns** |      **6.71 ns** |     **6.28 ns** |     **1.00** |    **0.01** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,348.4 ns |    101.07 ns |    84.40 ns |    10.97 |    0.16 |  0.1068 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,463.4 ns |     12.90 ns |    11.44 ns |     2.18 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,496.0 ns |     18.82 ns |    17.61 ns |     2.23 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |  10,324.6 ns |    120.50 ns |   112.71 ns |    15.41 |    0.21 |  0.1984 |      - |    3488 B |       11.18 |
|                             |        |              |              |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **692.1 ns** |     **11.61 ns** |    **10.86 ns** |     **1.00** |    **0.02** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 551,162.9 ns | 10,331.57 ns | 9,664.16 ns |   796.56 |   18.21 |  8.7891 | 1.9531 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   2,183.4 ns |     23.95 ns |    21.24 ns |     3.16 |    0.06 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   2,191.3 ns |     25.91 ns |    22.97 ns |     3.17 |    0.06 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 742,024.3 ns |  7,890.27 ns | 6,994.51 ns | 1,072.40 |   19.10 | 15.6250 | 6.8359 |  265856 B |      852.10 |
