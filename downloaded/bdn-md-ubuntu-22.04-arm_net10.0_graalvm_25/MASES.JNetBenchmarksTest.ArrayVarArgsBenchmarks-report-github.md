```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **562.2 ns** |     **0.53 ns** |     **0.47 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,345.4 ns |    36.86 ns |    34.48 ns |    13.06 |    0.06 | 0.0153 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,151.4 ns |     2.52 ns |     2.23 ns |     2.05 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,185.6 ns |     2.17 ns |     1.93 ns |     2.11 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,142.0 ns |    35.42 ns |    33.13 ns |    16.26 |    0.06 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **549.5 ns** |     **0.38 ns** |     **0.34 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 552,735.6 ns | 1,274.97 ns | 1,192.61 ns | 1,005.87 |    2.18 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,603.9 ns |     5.12 ns |     4.79 ns |     2.92 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,724.5 ns |     4.58 ns |     4.06 ns |     3.14 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 730,621.9 ns |   915.51 ns |   714.77 ns | 1,329.59 |    1.48 | 3.9063 | 0.9766 |  265856 B |      852.10 |
