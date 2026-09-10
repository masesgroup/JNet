```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 292.8 ns | 0.09 ns | 0.08 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 263.2 ns | 0.08 ns | 0.07 ns |  0.90 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 537.3 ns | 0.35 ns | 0.31 ns |  1.84 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 303.7 ns | 0.08 ns | 0.07 ns |  1.04 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 545.7 ns | 0.43 ns | 0.38 ns |  1.86 | 0.0048 |     344 B |          NA |
