```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 302.2 ns | 0.16 ns | 0.15 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 267.5 ns | 0.09 ns | 0.08 ns |  0.89 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 543.2 ns | 0.28 ns | 0.24 ns |  1.80 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 307.9 ns | 0.16 ns | 0.15 ns |  1.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 546.9 ns | 0.41 ns | 0.36 ns |  1.81 | 0.0048 |     344 B |          NA |
