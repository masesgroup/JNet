```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 302.3 ns | 0.14 ns | 0.14 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 268.3 ns | 0.10 ns | 0.10 ns |  0.89 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 536.0 ns | 0.48 ns | 0.42 ns |  1.77 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 309.0 ns | 0.13 ns | 0.13 ns |  1.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 552.0 ns | 0.69 ns | 0.61 ns |  1.83 | 0.0048 |     344 B |          NA |
