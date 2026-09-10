```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error     | StdDev    | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|----------:|----------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **559.7 ns** |   **0.38 ns** |   **0.32 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,158.5 ns |   9.63 ns |   8.54 ns |    12.79 |    0.02 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,187.8 ns |   1.57 ns |   1.39 ns |     2.12 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,198.4 ns |   1.78 ns |   1.58 ns |     2.14 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,252.2 ns |  27.58 ns |  25.79 ns |    16.53 |    0.05 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |           |           |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **571.0 ns** |   **0.39 ns** |   **0.33 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 576,275.6 ns | 758.20 ns | 709.22 ns | 1,009.23 |    1.32 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,952.6 ns |   7.52 ns |   7.03 ns |     3.42 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,919.8 ns |  16.11 ns |  14.28 ns |     3.36 |    0.02 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 753,298.5 ns | 731.94 ns | 611.21 ns | 1,319.25 |    1.26 | 3.9063 | 0.9766 |  265856 B |      852.10 |
