```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 304.9 ns | 0.10 ns | 0.08 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 271.5 ns | 0.09 ns | 0.08 ns |  0.89 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 538.5 ns | 0.57 ns | 0.50 ns |  1.77 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 305.3 ns | 0.12 ns | 0.11 ns |  1.00 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 540.4 ns | 0.35 ns | 0.27 ns |  1.77 | 0.0048 |     344 B |          NA |
