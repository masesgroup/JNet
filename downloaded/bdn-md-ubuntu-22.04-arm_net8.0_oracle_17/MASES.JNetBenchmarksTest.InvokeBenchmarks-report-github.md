```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 301.3 ns | 0.09 ns | 0.08 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 267.0 ns | 0.09 ns | 0.08 ns |  0.89 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 540.8 ns | 0.44 ns | 0.39 ns |  1.80 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 308.0 ns | 0.11 ns | 0.10 ns |  1.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 547.9 ns | 0.40 ns | 0.36 ns |  1.82 | 0.0048 |     344 B |          NA |
