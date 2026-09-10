```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 290.2 ns | 0.13 ns | 0.12 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 291.9 ns | 0.15 ns | 0.14 ns |  1.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 546.2 ns | 0.19 ns | 0.17 ns |  1.88 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 299.5 ns | 0.28 ns | 0.26 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 538.1 ns | 0.32 ns | 0.28 ns |  1.85 | 0.0038 |     312 B |          NA |
