```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 298.3 ns | 0.19 ns | 0.17 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 309.0 ns | 0.73 ns | 0.69 ns |  1.04 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 539.3 ns | 0.33 ns | 0.30 ns |  1.81 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 315.5 ns | 0.18 ns | 0.16 ns |  1.06 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 544.3 ns | 1.38 ns | 1.29 ns |  1.82 | 0.0038 |     312 B |          NA |
