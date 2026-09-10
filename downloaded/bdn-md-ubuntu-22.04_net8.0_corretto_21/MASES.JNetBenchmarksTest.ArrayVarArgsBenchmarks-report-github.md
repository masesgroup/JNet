```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.59GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error        | StdDev       | Median       | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|-------------:|-------------:|-------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **734.0 ns** |     **12.30 ns** |     **11.50 ns** |     **729.3 ns** |     **1.00** |    **0.02** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,932.6 ns |     76.06 ns |     71.15 ns |   7,937.2 ns |    10.81 |    0.19 |  0.1221 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,669.3 ns |     29.09 ns |     27.21 ns |   1,662.2 ns |     2.27 |    0.05 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,583.5 ns |     10.72 ns |      8.37 ns |   1,583.9 ns |     2.16 |    0.03 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |  10,387.5 ns |     89.63 ns |     79.46 ns |  10,371.6 ns |    14.15 |    0.24 |  0.1984 |      - |    3520 B |       10.23 |
|                             |        |              |              |              |              |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **736.5 ns** |      **8.52 ns** |      **7.56 ns** |     **735.0 ns** |     **1.00** |    **0.01** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 605,573.1 ns |  9,091.68 ns |  8,059.54 ns | 603,357.5 ns |   822.29 |   13.32 |  8.7891 | 1.9531 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   2,301.3 ns |     20.85 ns |     18.48 ns |   2,299.1 ns |     3.12 |    0.04 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   2,307.7 ns |     22.83 ns |     21.35 ns |   2,307.7 ns |     3.13 |    0.04 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 839,701.7 ns | 14,899.69 ns | 23,632.49 ns | 826,614.8 ns | 1,140.20 |   33.56 | 15.6250 | 6.8359 |  265888 B |      772.93 |
