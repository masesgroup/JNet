```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 287.9 ns | 0.29 ns | 0.24 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 298.2 ns | 0.33 ns | 0.31 ns |  1.04 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 553.2 ns | 0.29 ns | 0.25 ns |  1.92 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 303.1 ns | 0.19 ns | 0.18 ns |  1.05 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 556.0 ns | 0.66 ns | 0.58 ns |  1.93 | 0.0038 |     312 B |          NA |
