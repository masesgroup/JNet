```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 313.7 ns | 0.20 ns | 0.19 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 278.4 ns | 0.08 ns | 0.07 ns |  0.89 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 530.5 ns | 0.47 ns | 0.42 ns |  1.69 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 319.2 ns | 0.14 ns | 0.13 ns |  1.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 542.0 ns | 0.41 ns | 0.34 ns |  1.73 | 0.0048 |     344 B |          NA |
