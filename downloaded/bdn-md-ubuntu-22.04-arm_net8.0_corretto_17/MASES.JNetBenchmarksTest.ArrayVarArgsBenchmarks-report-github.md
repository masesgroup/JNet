```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev    | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|----------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **539.4 ns** |     **0.44 ns** |   **0.39 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,197.6 ns |     8.68 ns |   7.70 ns |    13.34 |    0.02 | 0.0305 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,208.5 ns |     2.34 ns |   2.18 ns |     2.24 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,232.1 ns |     2.66 ns |   2.49 ns |     2.28 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   9,803.4 ns |    55.24 ns |  51.67 ns |    18.17 |    0.09 | 0.0458 |      - |    3520 B |       10.23 |
|                             |        |              |             |           |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **548.1 ns** |     **0.40 ns** |   **0.35 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 585,466.7 ns | 1,010.46 ns | 895.75 ns | 1,068.23 |    1.71 | 1.9531 |      - |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,920.3 ns |     4.89 ns |   4.58 ns |     3.50 |    0.01 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,909.6 ns |     6.51 ns |   5.77 ns |     3.48 |    0.01 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 765,591.6 ns | 1,156.56 ns | 965.78 ns | 1,396.89 |    1.91 | 3.9063 | 0.9766 |  265888 B |      772.93 |
