```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 3.13GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error        | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|-------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **735.7 ns** |     **10.72 ns** |    **10.03 ns** |     **1.00** |    **0.02** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,942.4 ns |     65.49 ns |    54.69 ns |    10.80 |    0.16 |  0.1221 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,557.5 ns |     22.47 ns |    21.02 ns |     2.12 |    0.04 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,591.7 ns |     18.54 ns |    17.34 ns |     2.16 |    0.04 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |  10,456.8 ns |     95.57 ns |    84.72 ns |    14.22 |    0.22 |  0.1984 |      - |    3520 B |       10.23 |
|                             |        |              |              |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **715.7 ns** |     **10.55 ns** |     **9.87 ns** |     **1.00** |    **0.02** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 600,807.7 ns |  8,756.01 ns | 8,190.37 ns |   839.61 |   15.70 |  8.7891 | 1.9531 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   2,284.8 ns |     27.03 ns |    25.29 ns |     3.19 |    0.05 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   2,291.8 ns |     17.70 ns |    16.55 ns |     3.20 |    0.05 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 819,309.1 ns | 11,042.62 ns | 9,789.00 ns | 1,144.96 |   20.11 | 15.6250 | 6.8359 |  265888 B |      772.93 |
