```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 314.7 ns | 0.11 ns | 0.10 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 280.9 ns | 0.38 ns | 0.34 ns |  0.89 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 523.6 ns | 0.40 ns | 0.36 ns |  1.66 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 314.8 ns | 0.24 ns | 0.22 ns |  1.00 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 537.3 ns | 0.40 ns | 0.35 ns |  1.71 | 0.0048 |     344 B |          NA |
