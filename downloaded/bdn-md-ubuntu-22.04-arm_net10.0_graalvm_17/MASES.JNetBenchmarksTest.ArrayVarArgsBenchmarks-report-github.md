```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev    | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|----------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **555.5 ns** |     **0.41 ns** |   **0.37 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   6,971.3 ns |    11.24 ns |  10.52 ns |    12.55 |    0.02 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,184.6 ns |     1.06 ns |   0.88 ns |     2.13 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,157.8 ns |     1.23 ns |   1.09 ns |     2.08 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,249.3 ns |    11.43 ns |   9.55 ns |    16.65 |    0.02 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |             |           |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **553.8 ns** |     **0.58 ns** |   **0.48 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 558,368.6 ns | 1,025.23 ns | 908.84 ns | 1,008.21 |    1.80 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,753.7 ns |     8.90 ns |   8.33 ns |     3.17 |    0.01 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,752.2 ns |     4.80 ns |   4.49 ns |     3.16 |    0.01 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 742,896.7 ns |   352.19 ns | 294.10 ns | 1,341.40 |    1.23 | 3.9063 | 0.9766 |  265856 B |      852.10 |
