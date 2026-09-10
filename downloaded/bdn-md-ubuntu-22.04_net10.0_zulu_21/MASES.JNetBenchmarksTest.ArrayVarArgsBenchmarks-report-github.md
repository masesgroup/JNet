```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.85GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error        | StdDev       | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|-------------:|-------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **618.8 ns** |      **6.13 ns** |      **5.73 ns** |     **1.00** |    **0.01** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   6,884.5 ns |     75.82 ns |     67.21 ns |    11.13 |    0.14 |  0.1144 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,411.2 ns |     19.83 ns |     18.55 ns |     2.28 |    0.04 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,390.1 ns |     14.24 ns |     13.32 ns |     2.25 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,280.7 ns |    167.44 ns |    156.63 ns |    15.00 |    0.28 |  0.1984 |      - |    3488 B |       11.18 |
|                             |        |              |              |              |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **614.2 ns** |      **7.22 ns** |      **6.40 ns** |     **1.00** |    **0.01** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 517,304.5 ns |  8,832.35 ns |  8,261.79 ns |   842.26 |   15.49 |  8.7891 | 1.9531 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   2,223.1 ns |     19.82 ns |     18.54 ns |     3.62 |    0.05 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   2,211.5 ns |     14.02 ns |     13.11 ns |     3.60 |    0.04 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 737,567.5 ns | 14,079.89 ns | 13,170.34 ns | 1,200.88 |   23.96 | 15.6250 | 6.8359 |  265856 B |      852.10 |
