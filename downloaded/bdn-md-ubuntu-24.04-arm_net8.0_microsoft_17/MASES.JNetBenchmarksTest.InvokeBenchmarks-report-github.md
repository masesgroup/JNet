```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 297.3 ns | 0.12 ns | 0.11 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 258.1 ns | 0.07 ns | 0.06 ns |  0.87 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 544.4 ns | 0.32 ns | 0.28 ns |  1.83 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 307.9 ns | 0.18 ns | 0.16 ns |  1.04 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 529.0 ns | 0.35 ns | 0.31 ns |  1.78 | 0.0048 |     344 B |          NA |
