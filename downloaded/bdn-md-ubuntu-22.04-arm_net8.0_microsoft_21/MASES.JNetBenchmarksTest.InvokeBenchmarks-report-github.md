```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 310.2 ns | 0.12 ns | 0.11 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 280.6 ns | 0.25 ns | 0.23 ns |  0.90 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 531.5 ns | 0.39 ns | 0.32 ns |  1.71 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 313.3 ns | 0.12 ns | 0.11 ns |  1.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 528.7 ns | 0.83 ns | 0.74 ns |  1.70 | 0.0048 |     344 B |          NA |
