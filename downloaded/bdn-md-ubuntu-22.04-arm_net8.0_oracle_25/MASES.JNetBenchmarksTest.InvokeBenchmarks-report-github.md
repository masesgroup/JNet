```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 308.0 ns | 0.12 ns | 0.10 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 274.0 ns | 0.14 ns | 0.14 ns |  0.89 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 533.5 ns | 0.32 ns | 0.27 ns |  1.73 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 314.1 ns | 0.08 ns | 0.08 ns |  1.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 548.1 ns | 1.34 ns | 1.25 ns |  1.78 | 0.0048 |     344 B |          NA |
