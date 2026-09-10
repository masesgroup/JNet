```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 306.0 ns | 0.23 ns | 0.22 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 306.2 ns | 0.50 ns | 0.47 ns |  1.00 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 546.5 ns | 0.57 ns | 0.50 ns |  1.79 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 311.6 ns | 0.09 ns | 0.07 ns |  1.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 554.7 ns | 0.48 ns | 0.42 ns |  1.81 | 0.0038 |     312 B |          NA |
