```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev    | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|----------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **557.8 ns** |     **0.75 ns** |   **0.67 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,383.3 ns |    32.60 ns |  30.49 ns |    13.24 |    0.06 | 0.0153 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,146.0 ns |     1.56 ns |   1.38 ns |     2.05 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,155.2 ns |     1.82 ns |   1.70 ns |     2.07 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,173.0 ns |    24.73 ns |  23.14 ns |    16.44 |    0.04 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |             |           |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **549.5 ns** |     **0.44 ns** |   **0.37 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 567,888.2 ns |   991.25 ns | 927.21 ns | 1,033.40 |    1.77 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,860.4 ns |     6.92 ns |   6.48 ns |     3.39 |    0.01 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,856.1 ns |     8.89 ns |   8.32 ns |     3.38 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 733,168.6 ns | 1,034.22 ns | 916.81 ns | 1,334.17 |    1.83 | 3.9063 | 0.9766 |  265856 B |      852.10 |
