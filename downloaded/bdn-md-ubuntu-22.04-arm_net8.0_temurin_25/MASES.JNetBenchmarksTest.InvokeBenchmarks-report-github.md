```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 303.3 ns | 0.12 ns | 0.11 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 272.9 ns | 0.21 ns | 0.19 ns |  0.90 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 532.5 ns | 0.28 ns | 0.23 ns |  1.76 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 317.7 ns | 0.12 ns | 0.11 ns |  1.05 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 544.6 ns | 0.54 ns | 0.48 ns |  1.80 | 0.0048 |     344 B |          NA |
