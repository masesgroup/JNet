```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 3.68GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **509.1 ns** |     **5.22 ns** |     **4.89 ns** |     **1.00** |    **0.01** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   6,353.8 ns |    57.21 ns |    53.52 ns |    12.48 |    0.15 |  0.1221 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,218.7 ns |    11.10 ns |     9.84 ns |     2.39 |    0.03 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,217.5 ns |    14.66 ns |    12.99 ns |     2.39 |    0.03 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   7,995.1 ns |    75.80 ns |    59.18 ns |    15.71 |    0.18 |  0.1984 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **521.1 ns** |     **6.07 ns** |     **5.39 ns** |     **1.00** |    **0.01** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 480,633.7 ns | 6,967.54 ns | 6,176.55 ns |   922.39 |   14.68 |  8.7891 | 1.9531 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,931.7 ns |    15.75 ns |    14.74 ns |     3.71 |    0.05 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,963.2 ns |    16.04 ns |    15.01 ns |     3.77 |    0.05 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 650,264.2 ns | 6,695.06 ns | 5,934.99 ns | 1,247.93 |   16.59 | 15.6250 | 6.8359 |  265888 B |      772.93 |
