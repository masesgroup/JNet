```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 372.3 ns | 0.26 ns | 0.24 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 386.3 ns | 0.26 ns | 0.23 ns |  1.04 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 534.1 ns | 0.33 ns | 0.29 ns |  1.43 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 387.9 ns | 0.32 ns | 0.28 ns |  1.04 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 547.3 ns | 0.24 ns | 0.21 ns |  1.47 | 0.0038 |     312 B |          NA |
