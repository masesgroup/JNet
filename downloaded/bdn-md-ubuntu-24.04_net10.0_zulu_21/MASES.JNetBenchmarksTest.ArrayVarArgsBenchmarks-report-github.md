```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.87GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **486.5 ns** |     **5.00 ns** |     **4.67 ns** |     **1.00** |    **0.01** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   5,412.5 ns |    25.62 ns |    22.71 ns |    11.13 |    0.11 |  0.1144 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,119.6 ns |     4.71 ns |     4.18 ns |     2.30 |    0.02 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,090.5 ns |     3.85 ns |     3.41 ns |     2.24 |    0.02 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   7,682.5 ns |    60.37 ns |    56.47 ns |    15.79 |    0.18 |  0.1984 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **488.4 ns** |     **4.27 ns** |     **3.99 ns** |     **1.00** |    **0.01** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 392,428.3 ns | 1,691.60 ns | 1,412.56 ns |   803.55 |    6.93 |  9.2773 | 2.9297 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,859.2 ns |     4.76 ns |     4.22 ns |     3.81 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,827.9 ns |     6.60 ns |     5.85 ns |     3.74 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 595,693.4 ns | 2,387.95 ns | 2,233.69 ns | 1,219.76 |   10.59 | 15.6250 | 6.8359 |  265856 B |      852.10 |
