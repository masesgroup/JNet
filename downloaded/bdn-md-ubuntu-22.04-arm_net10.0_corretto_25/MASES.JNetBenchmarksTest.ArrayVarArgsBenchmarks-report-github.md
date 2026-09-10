```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **559.5 ns** |     **1.03 ns** |     **0.96 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,243.0 ns |    19.98 ns |    18.69 ns |    12.95 |    0.04 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,145.5 ns |     1.77 ns |     1.57 ns |     2.05 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,161.7 ns |     1.53 ns |     1.36 ns |     2.08 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,741.8 ns |    59.38 ns |    55.54 ns |    17.41 |    0.10 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **579.7 ns** |     **5.02 ns** |     **4.70 ns** |     **1.00** |    **0.01** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 557,019.1 ns | 1,088.91 ns | 1,018.56 ns |   960.99 |    7.73 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,901.5 ns |     5.72 ns |     5.07 ns |     3.28 |    0.03 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,918.1 ns |     6.00 ns |     5.62 ns |     3.31 |    0.03 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 739,427.1 ns | 1,774.46 ns | 1,481.76 ns | 1,275.69 |   10.31 | 3.9063 | 0.9766 |  265856 B |      852.10 |
