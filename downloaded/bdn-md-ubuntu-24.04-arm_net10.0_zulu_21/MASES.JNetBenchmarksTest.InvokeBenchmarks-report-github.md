```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 312.5 ns | 0.14 ns | 0.13 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 313.1 ns | 0.61 ns | 0.57 ns |  1.00 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 540.0 ns | 0.76 ns | 0.67 ns |  1.73 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 320.4 ns | 0.41 ns | 0.36 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 553.1 ns | 1.21 ns | 1.14 ns |  1.77 | 0.0038 |     312 B |          NA |
