```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 305.7 ns | 0.18 ns | 0.17 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 304.4 ns | 0.18 ns | 0.14 ns |  1.00 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 538.3 ns | 0.38 ns | 0.32 ns |  1.76 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 310.0 ns | 0.20 ns | 0.19 ns |  1.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 546.7 ns | 0.34 ns | 0.30 ns |  1.79 | 0.0038 |     312 B |          NA |
