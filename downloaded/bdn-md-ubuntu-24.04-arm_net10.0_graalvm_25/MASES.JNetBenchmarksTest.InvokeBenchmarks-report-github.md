```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 304.6 ns | 0.37 ns | 0.35 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 301.3 ns | 0.16 ns | 0.15 ns |  0.99 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 545.5 ns | 0.38 ns | 0.34 ns |  1.79 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 315.1 ns | 0.28 ns | 0.26 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 545.4 ns | 0.30 ns | 0.25 ns |  1.79 | 0.0038 |     312 B |          NA |
