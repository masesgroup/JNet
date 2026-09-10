```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 364.5 ns | 0.30 ns | 0.28 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 336.8 ns | 0.22 ns | 0.19 ns |  0.92 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 551.5 ns | 0.32 ns | 0.28 ns |  1.51 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 403.7 ns | 1.12 ns | 1.05 ns |  1.11 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 542.3 ns | 0.23 ns | 0.19 ns |  1.49 | 0.0048 |     344 B |          NA |
