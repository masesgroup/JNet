```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Median   | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|---------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 305.2 ns | 0.36 ns | 0.33 ns | 305.3 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 302.7 ns | 0.86 ns | 0.80 ns | 303.3 ns |  0.99 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 527.5 ns | 0.36 ns | 0.30 ns | 527.3 ns |  1.73 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 312.5 ns | 0.37 ns | 0.34 ns | 312.5 ns |  1.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 551.6 ns | 0.64 ns | 0.53 ns | 551.6 ns |  1.81 | 0.0038 |     312 B |          NA |
