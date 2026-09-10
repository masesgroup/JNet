```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.80GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error        | StdDev       | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|-------------:|-------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **710.9 ns** |     **12.25 ns** |     **11.46 ns** |     **1.00** |    **0.02** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,538.4 ns |    145.17 ns |    155.33 ns |    10.61 |    0.27 |  0.1221 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,494.4 ns |     20.33 ns |     16.98 ns |     2.10 |    0.04 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,537.4 ns |     24.13 ns |     22.57 ns |     2.16 |    0.05 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |  10,041.1 ns |    138.28 ns |    129.35 ns |    14.13 |    0.28 |  0.1984 |      - |    3520 B |       10.23 |
|                             |        |              |              |              |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **707.8 ns** |     **11.02 ns** |     **10.31 ns** |     **1.00** |    **0.02** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 562,131.8 ns |  5,155.05 ns |  4,822.04 ns |   794.41 |   13.02 |  8.7891 | 1.9531 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   2,238.5 ns |     33.41 ns |     31.25 ns |     3.16 |    0.06 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   2,173.3 ns |     37.81 ns |     35.37 ns |     3.07 |    0.07 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 794,862.4 ns | 13,529.97 ns | 11,993.97 ns | 1,123.31 |   22.80 | 15.6250 | 6.8359 |  265888 B |      772.93 |
