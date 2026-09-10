```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 308.0 ns | 0.31 ns | 0.29 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 309.9 ns | 0.39 ns | 0.36 ns |  1.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 548.7 ns | 0.33 ns | 0.29 ns |  1.78 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 317.1 ns | 1.07 ns | 1.00 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 554.7 ns | 0.39 ns | 0.35 ns |  1.80 | 0.0038 |     312 B |          NA |
