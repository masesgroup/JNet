```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 309.9 ns | 0.10 ns | 0.09 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 276.8 ns | 0.26 ns | 0.25 ns |  0.89 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 531.8 ns | 0.38 ns | 0.33 ns |  1.72 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 320.6 ns | 0.18 ns | 0.17 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 545.7 ns | 0.72 ns | 0.63 ns |  1.76 | 0.0048 |     344 B |          NA |
