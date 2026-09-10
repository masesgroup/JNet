```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 3.69GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **477.6 ns** |     **6.63 ns** |     **6.20 ns** |     **1.00** |    **0.02** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   5,489.2 ns |    67.14 ns |    62.80 ns |    11.49 |    0.19 |  0.1144 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,061.5 ns |    10.47 ns |     9.28 ns |     2.22 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,059.8 ns |    12.05 ns |    11.27 ns |     2.22 |    0.04 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   7,146.2 ns |    75.60 ns |    70.71 ns |    14.96 |    0.23 |  0.2060 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **467.0 ns** |     **5.67 ns** |     **5.03 ns** |     **1.00** |    **0.01** |  **0.0186** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 392,814.8 ns | 2,322.01 ns | 2,172.01 ns |   841.27 |    9.94 |  9.2773 | 2.9297 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,753.9 ns |    11.59 ns |    10.84 ns |     3.76 |    0.05 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,819.1 ns |    17.98 ns |    16.82 ns |     3.90 |    0.05 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 550,979.5 ns | 4,675.78 ns | 4,373.73 ns | 1,180.00 |   15.38 | 15.6250 | 6.8359 |  265856 B |      852.10 |
