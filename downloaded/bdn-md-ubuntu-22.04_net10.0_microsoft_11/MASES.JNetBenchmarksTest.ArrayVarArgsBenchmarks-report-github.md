```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.86GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error        | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|-------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **605.2 ns** |      **7.19 ns** |     **6.73 ns** |     **1.00** |    **0.02** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,602.3 ns |     58.67 ns |    52.01 ns |    12.56 |    0.16 |  0.1068 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,444.6 ns |     10.66 ns |     9.45 ns |     2.39 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,447.4 ns |     12.19 ns |    10.18 ns |     2.39 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,410.8 ns |    130.44 ns |   122.02 ns |    15.55 |    0.26 |  0.1984 |      - |    3488 B |       11.18 |
|                             |        |              |              |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **639.7 ns** |      **9.26 ns** |     **8.66 ns** |     **1.00** |    **0.02** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 540,655.9 ns |  6,721.27 ns | 6,287.08 ns |   845.33 |   14.55 |  8.7891 | 1.9531 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   2,285.4 ns |     32.17 ns |    30.09 ns |     3.57 |    0.07 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   2,287.9 ns |     24.34 ns |    22.77 ns |     3.58 |    0.06 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 743,277.1 ns | 10,409.87 ns | 9,737.40 ns | 1,162.13 |   21.13 | 15.6250 | 6.8359 |  265856 B |      852.10 |
