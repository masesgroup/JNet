```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Intel Xeon 6973P-C 4.10GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error        | StdDev       | Median       | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|-------------:|-------------:|-------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **389.2 ns** |      **7.68 ns** |     **11.50 ns** |     **383.5 ns** |     **1.00** |    **0.04** | **0.0033** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   4,852.4 ns |     96.38 ns |    131.93 ns |   4,807.5 ns |    12.48 |    0.49 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |     765.0 ns |     15.27 ns |     28.30 ns |     749.1 ns |     1.97 |    0.09 | 0.0048 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |     743.2 ns |      4.90 ns |      4.10 ns |     743.4 ns |     1.91 |    0.06 | 0.0048 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   7,472.5 ns |    140.28 ns |    155.92 ns |   7,465.1 ns |    19.22 |    0.67 | 0.0381 |      - |    3488 B |       11.18 |
|                             |        |              |              |              |              |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **380.4 ns** |      **4.31 ns** |      **3.60 ns** |     **379.5 ns** |     **1.00** |    **0.01** | **0.0033** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 378,987.1 ns |  5,538.02 ns |  4,624.49 ns | 378,639.2 ns |   996.34 |   14.78 | 1.4648 | 0.4883 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,287.6 ns |     11.20 ns |      9.93 ns |   1,284.4 ns |     3.39 |    0.04 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,295.5 ns |      7.16 ns |      5.98 ns |   1,295.2 ns |     3.41 |    0.03 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 629,531.4 ns | 12,410.88 ns | 26,178.77 ns | 632,196.4 ns | 1,655.00 |   69.85 | 2.9297 |      - |  265856 B |      852.10 |
