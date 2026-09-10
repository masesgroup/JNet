```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
INTEL XEON PLATINUM 8573C 3.04GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error        | StdDev       | Ratio    | RatioSD | Gen0   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|-------------:|-------------:|---------:|--------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **549.9 ns** |      **4.59 ns** |      **4.29 ns** |     **1.00** |    **0.01** | **0.0029** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   6,584.5 ns |     44.15 ns |     41.29 ns |    11.98 |    0.12 | 0.0229 |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,073.0 ns |     20.88 ns |     23.21 ns |     1.95 |    0.04 | 0.0038 |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,059.6 ns |      8.47 ns |      7.92 ns |     1.93 |    0.02 | 0.0038 |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |  10,566.2 ns |    206.54 ns |    309.14 ns |    19.22 |    0.57 | 0.0305 |    3488 B |       11.18 |
|                             |        |              |              |              |          |         |        |           |             |
| **InvokeIntParam**              | **1000**   |     **548.5 ns** |      **5.10 ns** |      **4.77 ns** |     **1.00** |    **0.01** | **0.0029** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 516,718.3 ns |  3,086.61 ns |  2,736.20 ns |   942.16 |    9.28 | 0.9766 |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,873.9 ns |     10.08 ns |      9.43 ns |     3.42 |    0.03 | 0.0038 |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,874.1 ns |     20.24 ns |     18.93 ns |     3.42 |    0.04 | 0.0038 |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 880,271.0 ns | 17,497.71 ns | 28,749.24 ns | 1,605.04 |   53.45 | 2.9297 |  265856 B |      852.10 |
