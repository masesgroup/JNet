```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **540.9 ns** |     **0.49 ns** |     **0.43 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,023.1 ns |     6.70 ns |     5.59 ns |    12.98 |    0.01 | 0.0305 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,222.3 ns |     1.67 ns |     1.48 ns |     2.26 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,202.4 ns |     2.12 ns |     1.77 ns |     2.22 |    0.00 | 0.0057 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   9,076.9 ns |    35.84 ns |    33.52 ns |    16.78 |    0.06 | 0.0458 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **533.7 ns** |     **0.34 ns** |     **0.30 ns** |     **1.00** |    **0.00** | **0.0048** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 563,539.0 ns | 1,139.39 ns | 1,065.79 ns | 1,055.85 |    2.02 | 1.9531 |      - |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,941.1 ns |     5.55 ns |     4.92 ns |     3.64 |    0.01 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,919.2 ns |    10.26 ns |     9.09 ns |     3.60 |    0.02 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 749,823.4 ns | 1,308.99 ns | 1,093.07 ns | 1,404.88 |    2.12 | 3.9063 | 0.9766 |  265888 B |      772.93 |
