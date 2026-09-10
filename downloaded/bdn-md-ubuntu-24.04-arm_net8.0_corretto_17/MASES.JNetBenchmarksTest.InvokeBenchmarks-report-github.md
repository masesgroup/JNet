```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 306.3 ns | 0.24 ns | 0.22 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 279.1 ns | 0.05 ns | 0.05 ns |  0.91 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 543.2 ns | 0.30 ns | 0.27 ns |  1.77 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 314.7 ns | 0.15 ns | 0.13 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 538.6 ns | 0.29 ns | 0.26 ns |  1.76 | 0.0048 |     344 B |          NA |
