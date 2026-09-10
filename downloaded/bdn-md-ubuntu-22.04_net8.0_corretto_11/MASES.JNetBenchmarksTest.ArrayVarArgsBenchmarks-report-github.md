```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 3.14GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **716.1 ns** |    **12.66 ns** |    **11.84 ns** |     **1.00** |    **0.02** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   8,069.8 ns |   116.78 ns |   103.53 ns |    11.27 |    0.23 |  0.1221 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,527.3 ns |    11.39 ns |    10.10 ns |     2.13 |    0.04 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,547.4 ns |    13.58 ns |    11.34 ns |     2.16 |    0.04 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |  10,045.9 ns |   142.59 ns |   133.38 ns |    14.03 |    0.29 |  0.1984 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **745.4 ns** |    **12.60 ns** |    **11.17 ns** |     **1.00** |    **0.02** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 620,189.3 ns | 6,582.34 ns | 5,835.07 ns |   832.17 |   14.13 |  8.7891 | 1.9531 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   2,309.8 ns |    21.88 ns |    19.39 ns |     3.10 |    0.05 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   2,317.7 ns |    24.22 ns |    21.47 ns |     3.11 |    0.05 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 987,141.5 ns | 4,520.61 ns | 3,774.92 ns | 1,324.54 |   19.62 | 15.6250 | 5.8594 |  265888 B |      772.93 |
