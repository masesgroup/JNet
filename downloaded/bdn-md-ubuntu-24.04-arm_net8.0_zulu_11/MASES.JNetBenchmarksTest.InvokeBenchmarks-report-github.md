```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 363.8 ns | 0.19 ns | 0.17 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 368.7 ns | 0.16 ns | 0.15 ns |  1.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 544.4 ns | 0.35 ns | 0.31 ns |  1.50 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 389.2 ns | 0.25 ns | 0.23 ns |  1.07 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 543.1 ns | 0.69 ns | 0.61 ns |  1.49 | 0.0048 |     344 B |          NA |
