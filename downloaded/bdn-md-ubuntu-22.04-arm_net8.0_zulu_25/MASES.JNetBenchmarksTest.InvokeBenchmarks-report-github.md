```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 314.3 ns | 0.14 ns | 0.13 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 278.1 ns | 0.10 ns | 0.09 ns |  0.88 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 536.2 ns | 0.40 ns | 0.36 ns |  1.71 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 320.4 ns | 0.11 ns | 0.09 ns |  1.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 565.7 ns | 0.36 ns | 0.32 ns |  1.80 | 0.0048 |     344 B |          NA |
