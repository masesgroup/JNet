```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.59GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error        | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|-------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **663.2 ns** |     **12.66 ns** |    **11.84 ns** |     **1.00** |    **0.02** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,807.6 ns |    136.12 ns |   127.33 ns |    11.78 |    0.28 |  0.1068 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,487.7 ns |     19.81 ns |    18.53 ns |     2.24 |    0.05 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,484.7 ns |     13.51 ns |    11.97 ns |     2.24 |    0.04 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,604.7 ns |     50.52 ns |    44.78 ns |    14.49 |    0.26 |  0.1984 |      - |    3488 B |       11.18 |
|                             |        |              |              |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **652.3 ns** |      **8.39 ns** |     **7.85 ns** |     **1.00** |    **0.02** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 591,584.3 ns |  7,011.09 ns | 6,215.15 ns |   907.09 |   14.00 |  8.7891 | 1.9531 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,961.6 ns |     33.75 ns |    31.57 ns |     3.01 |    0.06 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,980.6 ns |     13.74 ns |    11.47 ns |     3.04 |    0.04 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 804,388.6 ns | 10,520.59 ns | 9,840.97 ns | 1,233.39 |   20.47 | 15.6250 | 6.8359 |  265856 B |      852.10 |
