```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.87GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                      | Length | Mean         | Error        | StdDev       | Ratio    | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|-------------:|-------------:|---------:|--------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **655.2 ns** |      **8.64 ns** |      **7.66 ns** |     **1.00** |    **0.02** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,271.9 ns |    143.81 ns |    153.88 ns |    11.10 |    0.26 |  0.1068 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,432.1 ns |     11.98 ns |     10.01 ns |     2.19 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,398.5 ns |     16.52 ns |     14.65 ns |     2.13 |    0.03 |  0.0248 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   9,517.6 ns |    127.82 ns |    113.31 ns |    14.53 |    0.23 |  0.1984 |      - |    3488 B |       11.18 |
|                             |        |              |              |              |          |         |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **621.4 ns** |      **8.98 ns** |      **8.40 ns** |     **1.00** |    **0.02** |  **0.0181** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 520,979.8 ns |  7,536.75 ns |  7,049.88 ns |   838.48 |   15.43 |  8.7891 | 1.9531 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   2,055.5 ns |     31.45 ns |     26.27 ns |     3.31 |    0.06 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   2,011.6 ns |     21.14 ns |     19.77 ns |     3.24 |    0.05 |  0.0229 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 756,528.5 ns | 15,025.14 ns | 16,700.41 ns | 1,217.58 |   30.57 | 15.6250 | 5.8594 |  265856 B |      852.10 |
