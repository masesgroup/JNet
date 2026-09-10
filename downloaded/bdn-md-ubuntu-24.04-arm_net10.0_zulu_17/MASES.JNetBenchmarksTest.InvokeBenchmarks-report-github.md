```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 305.4 ns | 0.27 ns | 0.26 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 312.2 ns | 0.49 ns | 0.46 ns |  1.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 570.8 ns | 0.64 ns | 0.60 ns |  1.87 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 315.9 ns | 0.21 ns | 0.20 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 560.4 ns | 0.42 ns | 0.37 ns |  1.83 | 0.0038 |     312 B |          NA |
