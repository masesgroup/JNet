```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 303.0 ns | 0.17 ns | 0.16 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 308.1 ns | 0.75 ns | 0.71 ns |  1.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 563.1 ns | 0.70 ns | 0.59 ns |  1.86 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 316.2 ns | 0.17 ns | 0.16 ns |  1.04 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 568.5 ns | 0.39 ns | 0.32 ns |  1.88 | 0.0038 |     312 B |          NA |
