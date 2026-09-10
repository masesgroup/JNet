```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 309.3 ns | 0.14 ns | 0.12 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 319.0 ns | 0.09 ns | 0.08 ns |  1.03 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 550.9 ns | 0.39 ns | 0.35 ns |  1.78 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 312.8 ns | 1.07 ns | 1.00 ns |  1.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 563.0 ns | 0.17 ns | 0.15 ns |  1.82 | 0.0038 |     312 B |          NA |
