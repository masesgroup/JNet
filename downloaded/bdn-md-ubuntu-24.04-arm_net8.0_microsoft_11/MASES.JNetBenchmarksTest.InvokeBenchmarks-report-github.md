```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 376.0 ns | 0.25 ns | 0.24 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 350.0 ns | 0.27 ns | 0.25 ns |  0.93 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 542.4 ns | 0.22 ns | 0.20 ns |  1.44 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 385.5 ns | 0.18 ns | 0.17 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 538.0 ns | 0.32 ns | 0.29 ns |  1.43 | 0.0048 |     344 B |          NA |
