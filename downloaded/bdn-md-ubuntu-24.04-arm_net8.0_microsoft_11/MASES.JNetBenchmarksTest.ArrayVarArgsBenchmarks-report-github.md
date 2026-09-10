```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **533.2 ns** |     **0.50 ns** |     **0.44 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,188.2 ns |    18.15 ns |    16.97 ns |    13.48 |    0.03 | 0.0305 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,214.6 ns |     3.22 ns |     3.01 ns |     2.28 |    0.01 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,195.9 ns |     3.43 ns |     3.21 ns |     2.24 |    0.01 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   9,102.7 ns |    21.21 ns |    19.84 ns |    17.07 |    0.04 | 0.0458 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **532.8 ns** |     **0.54 ns** |     **0.48 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 570,805.7 ns | 1,915.35 ns | 1,791.62 ns | 1,071.26 |    3.39 | 1.9531 |      - |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,949.7 ns |    13.52 ns |    12.64 ns |     3.66 |    0.02 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,934.3 ns |    13.40 ns |    12.53 ns |     3.63 |    0.02 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 777,424.9 ns | 1,384.24 ns | 1,294.82 ns | 1,459.03 |    2.67 | 3.9063 | 0.9766 |  265888 B |      772.93 |
