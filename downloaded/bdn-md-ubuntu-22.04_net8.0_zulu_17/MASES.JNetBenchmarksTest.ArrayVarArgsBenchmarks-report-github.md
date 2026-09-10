```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.87GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error        | StdDev       | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|-------------:|-------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **707.6 ns** |      **9.29 ns** |      **8.24 ns** |     **1.00** |    **0.02** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   8,128.1 ns |    142.01 ns |    125.89 ns |    11.49 |    0.21 |  0.1221 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,567.6 ns |     12.71 ns |     10.61 ns |     2.22 |    0.03 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,594.5 ns |     17.04 ns |     15.94 ns |     2.25 |    0.03 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |  10,321.9 ns |    201.77 ns |    188.74 ns |    14.59 |    0.31 |  0.1984 |      - |    3520 B |       10.23 |
|                             |        |              |              |              |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **698.9 ns** |      **9.17 ns** |      **8.57 ns** |     **1.00** |    **0.02** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 617,697.2 ns | 11,194.99 ns | 10,994.98 ns |   883.97 |   18.49 |  8.7891 | 1.9531 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   2,394.2 ns |     37.67 ns |     35.24 ns |     3.43 |    0.06 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   2,404.5 ns |     22.79 ns |     20.21 ns |     3.44 |    0.05 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 827,283.5 ns | 14,107.31 ns | 13,195.98 ns | 1,183.90 |   23.01 | 15.6250 | 6.8359 |  265888 B |      772.93 |
