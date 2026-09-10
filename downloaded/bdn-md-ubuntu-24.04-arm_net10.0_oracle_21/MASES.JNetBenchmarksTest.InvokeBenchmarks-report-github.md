```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 301.1 ns | 0.30 ns | 0.28 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 306.9 ns | 0.69 ns | 0.65 ns |  1.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 523.7 ns | 0.43 ns | 0.38 ns |  1.74 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 316.7 ns | 0.18 ns | 0.17 ns |  1.05 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 555.7 ns | 0.29 ns | 0.25 ns |  1.85 | 0.0038 |     312 B |          NA |
