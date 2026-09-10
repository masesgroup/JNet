```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 302.0 ns | 0.08 ns | 0.07 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 308.6 ns | 0.54 ns | 0.50 ns |  1.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 535.3 ns | 0.35 ns | 0.31 ns |  1.77 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 311.9 ns | 0.48 ns | 0.45 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 554.4 ns | 0.45 ns | 0.40 ns |  1.84 | 0.0038 |     312 B |          NA |
