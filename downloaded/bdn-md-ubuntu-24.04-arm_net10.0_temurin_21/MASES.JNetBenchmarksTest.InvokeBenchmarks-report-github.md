```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 303.2 ns | 0.13 ns | 0.13 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 306.1 ns | 0.28 ns | 0.25 ns |  1.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 530.4 ns | 0.43 ns | 0.38 ns |  1.75 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 306.1 ns | 0.24 ns | 0.21 ns |  1.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 535.3 ns | 0.45 ns | 0.37 ns |  1.77 | 0.0038 |     312 B |          NA |
