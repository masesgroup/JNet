```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 291.7 ns | 0.16 ns | 0.14 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 296.9 ns | 0.34 ns | 0.31 ns |  1.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 554.0 ns | 1.23 ns | 1.15 ns |  1.90 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 299.0 ns | 0.13 ns | 0.12 ns |  1.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 556.1 ns | 0.42 ns | 0.37 ns |  1.91 | 0.0038 |     312 B |          NA |
