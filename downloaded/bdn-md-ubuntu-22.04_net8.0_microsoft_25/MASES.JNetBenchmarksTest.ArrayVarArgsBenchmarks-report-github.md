```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
INTEL XEON PLATINUM 8573C 2.99GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **584.5 ns** |     **5.63 ns** |     **5.26 ns** |     **1.00** |    **0.01** | **0.0038** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,211.6 ns |    43.45 ns |    40.64 ns |    12.34 |    0.13 | 0.0229 |      - |    2048 B |        5.95 |
| InvokeIntArrayFixed         | 10     |   1,309.6 ns |    10.80 ns |    10.10 ns |     2.24 |    0.03 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 10     |   1,233.3 ns |    12.70 ns |    11.88 ns |     2.11 |    0.03 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 10     |   9,249.9 ns |    90.45 ns |    84.61 ns |    15.83 |    0.20 | 0.0305 |      - |    3520 B |       10.23 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **579.3 ns** |     **5.88 ns** |     **5.50 ns** |     **1.00** |    **0.01** | **0.0038** |      **-** |     **344 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 581,640.7 ns | 4,606.20 ns | 4,308.64 ns | 1,004.12 |   11.69 | 0.9766 |      - |  160448 B |      466.42 |
| InvokeIntArrayFixed         | 1000   |   2,066.5 ns |    14.63 ns |    12.97 ns |     3.57 |    0.04 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsWholeArray     | 1000   |   2,030.4 ns |    13.97 ns |    12.39 ns |     3.51 |    0.04 | 0.0038 |      - |     448 B |        1.30 |
| InvokeVarArgsSpreadElements | 1000   | 747,099.6 ns | 4,572.12 ns | 3,817.93 ns | 1,289.77 |   13.43 | 2.9297 | 0.9766 |  265888 B |      772.93 |
