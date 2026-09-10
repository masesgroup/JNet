```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 374.5 ns | 0.32 ns | 0.30 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 382.1 ns | 2.70 ns | 2.52 ns |  1.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 551.7 ns | 0.23 ns | 0.18 ns |  1.47 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 387.5 ns | 0.30 ns | 0.26 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 546.7 ns | 0.24 ns | 0.21 ns |  1.46 | 0.0038 |     312 B |          NA |
