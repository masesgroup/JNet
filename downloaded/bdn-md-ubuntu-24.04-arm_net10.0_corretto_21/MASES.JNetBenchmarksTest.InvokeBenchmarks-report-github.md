```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 304.7 ns | 0.25 ns | 0.23 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 306.1 ns | 0.46 ns | 0.43 ns |  1.00 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 544.3 ns | 0.24 ns | 0.21 ns |  1.79 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 310.7 ns | 0.20 ns | 0.16 ns |  1.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 544.9 ns | 0.43 ns | 0.38 ns |  1.79 | 0.0038 |     312 B |          NA |
