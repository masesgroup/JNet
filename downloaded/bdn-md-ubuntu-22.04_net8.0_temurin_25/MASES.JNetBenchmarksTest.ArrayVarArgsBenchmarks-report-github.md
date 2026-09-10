```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.63GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error        | StdDev       | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|-------------:|-------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **767.8 ns** |     **10.80 ns** |      **9.02 ns** |     **1.00** |    **0.02** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,669.9 ns |     75.80 ns |     63.29 ns |     9.99 |    0.14 |  0.1221 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,586.3 ns |     23.90 ns |     22.36 ns |     2.07 |    0.04 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,584.1 ns |     17.54 ns |     14.64 ns |     2.06 |    0.03 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |  10,386.3 ns |    134.55 ns |    125.86 ns |    13.53 |    0.22 |  0.1984 |      - |    3520 B |       10.23 |
|                             |        |              |              |              |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **729.0 ns** |     **12.53 ns** |     **11.72 ns** |     **1.00** |    **0.02** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 598,919.8 ns |  6,827.56 ns |  6,052.46 ns |   821.75 |   15.08 |  8.7891 | 1.9531 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   2,287.0 ns |     16.25 ns |     15.20 ns |     3.14 |    0.05 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   2,298.5 ns |     32.45 ns |     30.36 ns |     3.15 |    0.06 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 834,282.0 ns | 11,327.86 ns | 10,596.09 ns | 1,144.68 |   22.68 | 15.6250 | 6.8359 |  265888 B |      772.93 |
