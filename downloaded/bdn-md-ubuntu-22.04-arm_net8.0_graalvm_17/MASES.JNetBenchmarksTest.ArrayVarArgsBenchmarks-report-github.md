```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev    | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|----------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **536.4 ns** |     **1.23 ns** |   **1.09 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,087.7 ns |     8.79 ns |   7.79 ns |    13.21 |    0.03 | 0.0305 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,188.1 ns |     1.15 ns |   1.02 ns |     2.22 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,195.0 ns |     0.77 ns |   0.68 ns |     2.23 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   9,382.9 ns |    33.89 ns |  31.70 ns |    17.49 |    0.07 | 0.0458 |      - |    3520 B |       10.23 |
|                             |        |              |             |           |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **550.5 ns** |     **0.43 ns** |   **0.38 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 563,116.0 ns | 1,017.22 ns | 951.51 ns | 1,022.99 |    1.81 | 1.9531 |      - |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,758.2 ns |    10.03 ns |   9.39 ns |     3.19 |    0.02 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,783.3 ns |     8.17 ns |   7.24 ns |     3.24 |    0.01 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 756,483.5 ns |   512.60 ns | 428.04 ns | 1,374.27 |    1.19 | 3.9063 | 0.9766 |  265888 B |      772.93 |
