```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.61GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **707.5 ns** |     **7.76 ns** |     **7.26 ns** |     **1.00** |    **0.01** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,864.3 ns |    99.30 ns |    88.02 ns |    11.12 |    0.16 |  0.1068 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,509.8 ns |    13.78 ns |    12.22 ns |     2.13 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,522.7 ns |    17.48 ns |    16.35 ns |     2.15 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |  10,001.4 ns |    55.33 ns |    49.05 ns |    14.14 |    0.15 |  0.1984 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **692.1 ns** |     **9.33 ns** |     **8.73 ns** |     **1.00** |    **0.02** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 619,316.1 ns | 4,962.20 ns | 4,143.66 ns |   895.02 |   12.27 |  8.7891 | 1.9531 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   2,315.1 ns |    15.84 ns |    14.81 ns |     3.35 |    0.05 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   2,229.2 ns |    22.29 ns |    20.85 ns |     3.22 |    0.05 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 802,366.8 ns | 7,619.91 ns | 7,127.67 ns | 1,159.56 |   17.21 | 15.6250 | 6.8359 |  265856 B |      852.10 |
