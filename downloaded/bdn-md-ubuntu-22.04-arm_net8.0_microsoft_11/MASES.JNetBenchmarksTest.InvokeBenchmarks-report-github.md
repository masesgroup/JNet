```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 380.7 ns | 0.21 ns | 0.20 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 347.6 ns | 0.16 ns | 0.15 ns |  0.91 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 545.0 ns | 0.31 ns | 0.26 ns |  1.43 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 392.5 ns | 0.26 ns | 0.23 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 539.0 ns | 0.16 ns | 0.13 ns |  1.42 | 0.0048 |     344 B |          NA |
