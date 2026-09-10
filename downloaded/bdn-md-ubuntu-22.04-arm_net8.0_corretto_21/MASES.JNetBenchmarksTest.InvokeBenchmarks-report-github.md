```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 312.6 ns | 0.14 ns | 0.13 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 276.0 ns | 0.25 ns | 0.23 ns |  0.88 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 536.2 ns | 0.42 ns | 0.38 ns |  1.72 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 319.0 ns | 0.35 ns | 0.33 ns |  1.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 543.4 ns | 0.34 ns | 0.30 ns |  1.74 | 0.0048 |     344 B |          NA |
