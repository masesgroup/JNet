```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 315.1 ns | 0.09 ns | 0.08 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 280.7 ns | 0.19 ns | 0.18 ns |  0.89 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 532.9 ns | 0.45 ns | 0.40 ns |  1.69 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 316.7 ns | 0.16 ns | 0.15 ns |  1.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 548.9 ns | 0.69 ns | 0.54 ns |  1.74 | 0.0048 |     344 B |          NA |
