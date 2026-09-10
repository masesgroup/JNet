```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.87GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error        | StdDev       | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|-------------:|-------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **702.8 ns** |      **6.20 ns** |      **5.50 ns** |     **1.00** |    **0.01** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,981.0 ns |    110.76 ns |     98.19 ns |    11.36 |    0.16 |  0.1221 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,533.8 ns |     23.18 ns |     20.55 ns |     2.18 |    0.03 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,541.2 ns |     17.81 ns |     15.79 ns |     2.19 |    0.03 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |  10,592.9 ns |    152.11 ns |    134.84 ns |    15.07 |    0.22 |  0.1984 |      - |    3520 B |       10.23 |
|                             |        |              |              |              |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **679.0 ns** |      **6.35 ns** |      **5.31 ns** |     **1.00** |    **0.01** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 594,233.8 ns |  8,155.73 ns |  7,229.84 ns |   875.19 |   12.18 |  8.7891 | 1.9531 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   2,415.6 ns |     22.82 ns |     20.23 ns |     3.56 |    0.04 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   2,417.9 ns |     27.73 ns |     25.94 ns |     3.56 |    0.05 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 837,495.0 ns | 12,851.77 ns | 12,021.55 ns | 1,233.46 |   19.46 | 15.6250 | 6.8359 |  265888 B |      772.93 |
