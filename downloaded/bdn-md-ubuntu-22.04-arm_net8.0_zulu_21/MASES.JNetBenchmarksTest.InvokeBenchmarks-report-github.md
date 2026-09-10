```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 315.6 ns | 0.26 ns | 0.25 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 275.3 ns | 0.13 ns | 0.11 ns |  0.87 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 533.7 ns | 0.71 ns | 0.63 ns |  1.69 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 325.2 ns | 0.18 ns | 0.16 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 561.8 ns | 0.60 ns | 0.53 ns |  1.78 | 0.0048 |     344 B |          NA |
