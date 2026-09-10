```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.63GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error        | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|-------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **673.5 ns** |      **6.47 ns** |     **5.74 ns** |     **1.00** |    **0.01** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,274.2 ns |     44.40 ns |    39.36 ns |    10.80 |    0.10 |  0.1144 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,514.3 ns |      9.88 ns |     8.76 ns |     2.25 |    0.02 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,483.4 ns |     18.01 ns |    16.85 ns |     2.20 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,802.1 ns |     62.47 ns |    52.16 ns |    14.56 |    0.14 |  0.1984 |      - |    3488 B |       11.18 |
|                             |        |              |              |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **681.5 ns** |      **9.06 ns** |     **8.47 ns** |     **1.00** |    **0.02** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 554,596.1 ns |  4,486.50 ns | 3,746.43 ns |   813.86 |   11.10 |  8.7891 | 1.9531 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   2,227.3 ns |     22.94 ns |    21.46 ns |     3.27 |    0.05 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   2,222.9 ns |     21.67 ns |    18.09 ns |     3.26 |    0.05 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 785,359.8 ns | 10,673.01 ns | 9,983.54 ns | 1,152.50 |   19.80 | 15.6250 | 6.8359 |  265856 B |      852.10 |
