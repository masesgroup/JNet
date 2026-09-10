```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **559.0 ns** |     **0.65 ns** |     **0.57 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   6,857.3 ns |    11.50 ns |    10.75 ns |    12.27 |    0.02 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,152.4 ns |     1.95 ns |     1.73 ns |     2.06 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,141.6 ns |     1.30 ns |     1.16 ns |     2.04 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   8,936.4 ns |    32.19 ns |    30.12 ns |    15.99 |    0.05 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **564.1 ns** |     **0.30 ns** |     **0.25 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 551,086.3 ns | 1,283.97 ns | 1,138.21 ns |   976.91 |    1.99 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,871.2 ns |     5.91 ns |     5.53 ns |     3.32 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,886.1 ns |     3.39 ns |     3.00 ns |     3.34 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 731,310.7 ns | 1,238.03 ns | 1,033.81 ns | 1,296.39 |    1.85 | 3.9063 | 0.9766 |  265856 B |      852.10 |
