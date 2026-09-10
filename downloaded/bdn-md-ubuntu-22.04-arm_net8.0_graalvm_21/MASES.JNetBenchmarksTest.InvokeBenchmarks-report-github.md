```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 306.8 ns | 0.15 ns | 0.14 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 272.0 ns | 0.12 ns | 0.11 ns |  0.89 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 526.8 ns | 0.55 ns | 0.49 ns |  1.72 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 323.4 ns | 0.16 ns | 0.15 ns |  1.05 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 533.5 ns | 0.42 ns | 0.33 ns |  1.74 | 0.0048 |     344 B |          NA |
