```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 303.0 ns | 0.20 ns | 0.18 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 274.2 ns | 0.30 ns | 0.28 ns |  0.91 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 526.9 ns | 0.30 ns | 0.26 ns |  1.74 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 323.2 ns | 0.08 ns | 0.07 ns |  1.07 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 544.3 ns | 0.38 ns | 0.30 ns |  1.80 | 0.0048 |     344 B |          NA |
