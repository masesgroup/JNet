```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 378.6 ns | 0.20 ns | 0.18 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 345.9 ns | 0.20 ns | 0.19 ns |  0.91 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 548.2 ns | 0.75 ns | 0.70 ns |  1.45 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 380.2 ns | 0.22 ns | 0.20 ns |  1.00 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 539.0 ns | 0.46 ns | 0.40 ns |  1.42 | 0.0048 |     344 B |          NA |
