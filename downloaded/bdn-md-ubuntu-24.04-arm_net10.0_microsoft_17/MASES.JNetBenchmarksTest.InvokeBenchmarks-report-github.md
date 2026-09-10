```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 293.8 ns | 0.18 ns | 0.15 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 297.9 ns | 0.10 ns | 0.09 ns |  1.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 529.8 ns | 0.30 ns | 0.27 ns |  1.80 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 298.4 ns | 0.22 ns | 0.18 ns |  1.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 546.9 ns | 0.30 ns | 0.26 ns |  1.86 | 0.0038 |     312 B |          NA |
