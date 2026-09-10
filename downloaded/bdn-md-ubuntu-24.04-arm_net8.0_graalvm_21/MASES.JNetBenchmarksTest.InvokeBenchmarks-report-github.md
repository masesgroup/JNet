```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 308.3 ns | 0.12 ns | 0.11 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 268.5 ns | 0.10 ns | 0.08 ns |  0.87 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 533.2 ns | 0.33 ns | 0.29 ns |  1.73 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 314.6 ns | 0.18 ns | 0.16 ns |  1.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 539.2 ns | 0.20 ns | 0.18 ns |  1.75 | 0.0048 |     344 B |          NA |
