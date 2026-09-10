```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                      | Length | Mean         | Error     | StdDev    | Ratio    | RatioSD | Gen0   | Gen1   | Allocated | Alloc Ratio |
|---------------------------- |------- |-------------:|----------:|----------:|---------:|--------:|-------:|-------:|----------:|------------:|
| **InvokeIntParam**              | **10**     |     **549.1 ns** |   **0.36 ns** |   **0.32 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 10     |   6,829.9 ns |   7.36 ns |   6.53 ns |    12.44 |    0.01 | 0.0229 |      - |    2016 B |        6.46 |
| InvokeIntArrayFixed         | 10     |   1,133.2 ns |   2.23 ns |   1.98 ns |     2.06 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 10     |   1,144.7 ns |   1.22 ns |   1.02 ns |     2.08 |    0.00 | 0.0057 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 10     |   8,727.4 ns |  25.97 ns |  23.02 ns |    15.89 |    0.04 | 0.0458 |      - |    3488 B |       11.18 |
|                             |        |              |           |           |          |         |        |        |           |             |
| **InvokeIntParam**              | **1000**   |     **540.7 ns** |   **0.78 ns** |   **0.69 ns** |     **1.00** |    **0.00** | **0.0038** |      **-** |     **312 B** |        **1.00** |
| InvokeStringArrayFixed      | 1000   | 550,062.4 ns | 906.54 ns | 847.98 ns | 1,017.30 |    1.97 | 1.9531 |      - |  160416 B |      514.15 |
| InvokeIntArrayFixed         | 1000   |   1,854.8 ns |   8.63 ns |   8.08 ns |     3.43 |    0.02 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsWholeArray     | 1000   |   1,870.7 ns |   5.67 ns |   5.03 ns |     3.46 |    0.01 | 0.0038 |      - |     416 B |        1.33 |
| InvokeVarArgsSpreadElements | 1000   | 715,865.0 ns | 404.94 ns | 338.14 ns | 1,323.94 |    1.75 | 3.9063 | 0.9766 |  265856 B |      852.10 |
