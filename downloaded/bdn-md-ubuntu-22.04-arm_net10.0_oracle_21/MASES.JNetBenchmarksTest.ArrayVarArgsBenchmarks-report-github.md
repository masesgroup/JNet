```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error       | StdDev      | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|------------:|------------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **549.4 ns** |     **0.92 ns** |     **0.77 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   7,294.1 ns |    21.29 ns |    19.91 ns |    13.28 |    0.04 | 0.0153 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,163.7 ns |     2.23 ns |     1.97 ns |     2.12 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,144.6 ns |     1.38 ns |     1.23 ns |     2.08 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   8,952.7 ns |    21.25 ns |    19.88 ns |    16.30 |    0.04 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |             |             |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **540.3 ns** |     **0.50 ns** |     **0.44 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 553,928.0 ns |   936.18 ns |   875.70 ns | 1,025.26 |    1.77 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,857.7 ns |     3.21 ns |     2.85 ns |     3.44 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,891.8 ns |     5.96 ns |     5.58 ns |     3.50 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 712,422.6 ns | 1,226.25 ns | 1,023.98 ns | 1,318.61 |    2.10 | 3.9063 | 0.9766 |  265856 B |      852.10 |
