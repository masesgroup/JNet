```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V45 4.52GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **362.7 ns** |     **6.27 ns** |     **6.44 ns** |     **1.00** |    **0.02** |  **0.0205** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   4,467.3 ns |    88.39 ns |    78.35 ns |    12.32 |    0.30 |  0.1221 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |     871.2 ns |    11.67 ns |    10.35 ns |     2.40 |    0.05 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |     877.2 ns |     9.00 ns |     7.98 ns |     2.42 |    0.05 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   5,623.9 ns |    78.41 ns |    69.51 ns |    15.51 |    0.32 |  0.2060 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **356.5 ns** |     **7.03 ns** |     **8.89 ns** |     **1.00** |    **0.03** |  **0.0205** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 347,206.9 ns | 5,631.16 ns | 5,782.79 ns |   974.46 |   28.35 |  9.2773 | 2.9297 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,322.1 ns |    15.23 ns |    12.72 ns |     3.71 |    0.10 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,313.9 ns |    14.69 ns |    13.02 ns |     3.69 |    0.10 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 462,442.9 ns | 9,141.68 ns | 8,978.35 ns | 1,297.87 |   39.77 | 15.6250 | 7.3242 |  265888 B |      772.93 |
