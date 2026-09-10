```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 306.0 ns | 0.14 ns | 0.11 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 272.8 ns | 0.13 ns | 0.12 ns |  0.89 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 536.9 ns | 0.30 ns | 0.27 ns |  1.75 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 313.8 ns | 0.13 ns | 0.11 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 557.9 ns | 0.26 ns | 0.23 ns |  1.82 | 0.0048 |     344 B |          NA |
