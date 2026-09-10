```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 3.69GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **549.6 ns** |     **7.25 ns** |     **6.78 ns** |     **1.00** |    **0.02** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   5,999.8 ns |    80.00 ns |    74.83 ns |    10.92 |    0.18 |  0.1221 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,190.2 ns |    16.54 ns |    15.48 ns |     2.17 |    0.04 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,228.3 ns |    12.99 ns |    11.52 ns |     2.24 |    0.03 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   7,989.7 ns |    61.79 ns |    57.79 ns |    14.54 |    0.20 |  0.1984 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **535.8 ns** |    **10.49 ns** |    **10.30 ns** |     **1.00** |    **0.03** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 450,923.1 ns | 5,751.43 ns | 5,379.89 ns |   841.82 |   18.48 |  9.2773 | 2.9297 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,933.1 ns |    15.88 ns |    14.85 ns |     3.61 |    0.07 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,934.3 ns |    14.99 ns |    13.29 ns |     3.61 |    0.07 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 636,008.5 ns | 8,963.80 ns | 7,946.17 ns | 1,187.35 |   26.40 | 15.6250 | 6.8359 |  265888 B |      772.93 |
