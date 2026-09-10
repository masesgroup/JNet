```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 380.4 ns | 0.22 ns | 0.20 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 345.6 ns | 0.21 ns | 0.19 ns |  0.91 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 535.3 ns | 0.63 ns | 0.56 ns |  1.41 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 398.7 ns | 0.23 ns | 0.22 ns |  1.05 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 542.7 ns | 0.84 ns | 0.70 ns |  1.43 | 0.0048 |     344 B |          NA |
