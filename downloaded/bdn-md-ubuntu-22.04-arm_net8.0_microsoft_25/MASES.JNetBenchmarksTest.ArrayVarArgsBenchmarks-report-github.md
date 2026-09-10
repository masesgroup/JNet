```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev    | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|----------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **548.8 ns** |     **0.60 ns** |   **0.57 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,060.1 ns |     6.49 ns |   5.42 ns |    12.86 |    0.02 | 0.0305 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,206.5 ns |     2.04 ns |   1.81 ns |     2.20 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,202.5 ns |     1.94 ns |   1.82 ns |     2.19 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   9,080.5 ns |    32.37 ns |  30.28 ns |    16.55 |    0.06 | 0.0458 |      - |    3520 B |       10.23 |
|                             |        |              |             |           |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **543.7 ns** |     **0.70 ns** |   **0.66 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 557,305.8 ns | 1,038.12 ns | 971.06 ns | 1,025.06 |    2.10 | 1.9531 |      - |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,905.7 ns |     8.34 ns |   7.40 ns |     3.51 |    0.01 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,909.3 ns |     9.66 ns |   9.04 ns |     3.51 |    0.02 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 739,840.9 ns |   988.83 ns | 772.02 ns | 1,360.80 |    2.09 | 3.9063 | 0.9766 |  265888 B |      772.93 |
