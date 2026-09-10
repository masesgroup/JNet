```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 306.1 ns | 0.16 ns | 0.14 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 269.1 ns | 0.08 ns | 0.07 ns |  0.88 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 531.5 ns | 0.29 ns | 0.26 ns |  1.74 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 314.3 ns | 0.09 ns | 0.08 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 538.9 ns | 0.52 ns | 0.46 ns |  1.76 | 0.0048 |     344 B |          NA |
