```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 316.2 ns | 0.17 ns | 0.16 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 274.7 ns | 0.11 ns | 0.10 ns |  0.87 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 519.0 ns | 0.29 ns | 0.23 ns |  1.64 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 316.4 ns | 0.15 ns | 0.14 ns |  1.00 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 533.5 ns | 0.33 ns | 0.29 ns |  1.69 | 0.0048 |     344 B |          NA |
