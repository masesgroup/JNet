```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 363.7 ns | 0.72 ns | 0.67 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 380.7 ns | 0.18 ns | 0.16 ns |  1.05 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 534.1 ns | 0.27 ns | 0.24 ns |  1.47 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 373.1 ns | 0.32 ns | 0.30 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 530.6 ns | 0.34 ns | 0.29 ns |  1.46 | 0.0038 |     312 B |          NA |
