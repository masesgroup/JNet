```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 314.0 ns | 0.16 ns | 0.15 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 278.5 ns | 0.10 ns | 0.09 ns |  0.89 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 534.8 ns | 0.31 ns | 0.28 ns |  1.70 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 317.6 ns | 0.22 ns | 0.20 ns |  1.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 539.1 ns | 0.29 ns | 0.26 ns |  1.72 | 0.0048 |     344 B |          NA |
