```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 293.4 ns | 0.14 ns | 0.13 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 264.3 ns | 0.17 ns | 0.16 ns |  0.90 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 549.6 ns | 0.26 ns | 0.23 ns |  1.87 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 309.5 ns | 0.16 ns | 0.15 ns |  1.06 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 542.3 ns | 0.41 ns | 0.32 ns |  1.85 | 0.0048 |     344 B |          NA |
