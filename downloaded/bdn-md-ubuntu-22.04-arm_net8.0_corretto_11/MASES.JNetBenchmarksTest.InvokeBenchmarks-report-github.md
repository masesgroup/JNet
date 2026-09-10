```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 376.4 ns | 0.15 ns | 0.13 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 346.4 ns | 0.20 ns | 0.17 ns |  0.92 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 530.1 ns | 0.36 ns | 0.32 ns |  1.41 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 391.3 ns | 0.18 ns | 0.17 ns |  1.04 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 544.6 ns | 0.26 ns | 0.23 ns |  1.45 | 0.0048 |     344 B |          NA |
