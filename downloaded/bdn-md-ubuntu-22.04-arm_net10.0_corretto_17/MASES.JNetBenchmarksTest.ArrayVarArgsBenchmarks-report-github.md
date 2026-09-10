```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev    | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|----------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **566.8 ns** |     **0.95 ns** |   **0.89 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,433.7 ns |    22.47 ns |  17.54 ns |    13.12 |    0.04 | 0.0153 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,143.2 ns |     1.68 ns |   1.57 ns |     2.02 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,154.5 ns |     1.28 ns |   1.07 ns |     2.04 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,557.9 ns |    37.98 ns |  35.53 ns |    16.86 |    0.07 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |             |           |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **561.9 ns** |     **0.55 ns** |   **0.49 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 557,578.3 ns |   895.25 ns | 698.95 ns |   992.40 |    1.46 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,859.2 ns |     4.56 ns |   4.04 ns |     3.31 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,848.9 ns |     2.04 ns |   1.71 ns |     3.29 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 744,872.3 ns | 1,174.36 ns | 980.65 ns | 1,325.75 |    2.01 | 3.9063 | 0.9766 |  265856 B |      852.10 |
