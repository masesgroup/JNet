```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 308.4 ns | 0.17 ns | 0.16 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 271.5 ns | 0.13 ns | 0.12 ns |  0.88 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 525.6 ns | 0.36 ns | 0.32 ns |  1.70 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 315.9 ns | 0.19 ns | 0.17 ns |  1.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 527.6 ns | 0.30 ns | 0.25 ns |  1.71 | 0.0048 |     344 B |          NA |
