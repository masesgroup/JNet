```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **440.9 ns** |     **6.61 ns** |     **6.18 ns** |     **1.00** |    **0.02** | **0.0033** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   5,818.1 ns |    60.70 ns |    56.78 ns |    13.20 |    0.22 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |     902.4 ns |     7.76 ns |     7.26 ns |     2.05 |    0.03 | 0.0048 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |     894.0 ns |     7.80 ns |     7.29 ns |     2.03 |    0.03 | 0.0048 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,113.3 ns |   165.36 ns |   154.68 ns |    20.67 |    0.44 | 0.0305 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **442.3 ns** |     **5.49 ns** |     **4.87 ns** |     **1.00** |    **0.02** | **0.0033** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 469,216.3 ns | 3,298.83 ns | 3,085.73 ns | 1,060.90 |   13.19 | 1.4648 | 0.4883 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,703.0 ns |    12.81 ns |    11.98 ns |     3.85 |    0.05 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,697.1 ns |     8.90 ns |     7.43 ns |     3.84 |    0.04 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 762,238.5 ns | 5,014.94 ns | 4,445.61 ns | 1,723.43 |   20.81 | 2.9297 |      - |  265856 B |      852.10 |
