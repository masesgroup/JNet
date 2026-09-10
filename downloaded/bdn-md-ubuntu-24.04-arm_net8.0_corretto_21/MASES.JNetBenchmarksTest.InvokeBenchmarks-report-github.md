```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 317.4 ns | 1.76 ns | 1.64 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 277.4 ns | 0.10 ns | 0.09 ns |  0.87 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 528.4 ns | 0.63 ns | 0.59 ns |  1.66 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 317.0 ns | 0.11 ns | 0.10 ns |  1.00 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 542.1 ns | 0.40 ns | 0.33 ns |  1.71 | 0.0048 |     344 B |          NA |
