```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 309.5 ns | 0.22 ns | 0.20 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 278.1 ns | 0.15 ns | 0.14 ns |  0.90 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 531.7 ns | 0.29 ns | 0.24 ns |  1.72 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 325.5 ns | 0.25 ns | 0.24 ns |  1.05 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 545.9 ns | 0.42 ns | 0.37 ns |  1.76 | 0.0048 |     344 B |          NA |
