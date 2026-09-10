```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **535.2 ns** |     **1.67 ns** |     **1.30 ns** |     **1.00** |    **0.00** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   6,536.7 ns |    16.57 ns |    15.50 ns |    12.21 |    0.04 |  0.1221 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,289.0 ns |     6.78 ns |     6.01 ns |     2.41 |    0.01 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,275.3 ns |     5.08 ns |     4.50 ns |     2.38 |    0.01 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   8,614.6 ns |    82.96 ns |    73.54 ns |    16.09 |    0.14 |  0.1984 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **568.6 ns** |     **4.38 ns** |     **3.89 ns** |     **1.00** |    **0.01** |  **0.0200** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 479,412.4 ns | 1,578.07 ns | 1,398.91 ns |   843.25 |    6.08 |  9.2773 | 2.9297 |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   1,703.3 ns |     5.60 ns |     4.96 ns |     3.00 |    0.02 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   1,716.8 ns |     8.97 ns |     8.39 ns |     3.02 |    0.02 |  0.0267 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 685,649.5 ns | 2,131.03 ns | 1,889.10 ns | 1,206.00 |    8.62 | 15.6250 | 6.8359 |  265889 B |      772.93 |
