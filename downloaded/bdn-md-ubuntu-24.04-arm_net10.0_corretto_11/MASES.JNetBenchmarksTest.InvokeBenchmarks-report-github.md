```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 369.8 ns | 0.19 ns | 0.18 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 363.0 ns | 0.18 ns | 0.16 ns |  0.98 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 538.4 ns | 0.47 ns | 0.42 ns |  1.46 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 380.3 ns | 0.18 ns | 0.15 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 538.4 ns | 0.25 ns | 0.22 ns |  1.46 | 0.0038 |     312 B |          NA |
