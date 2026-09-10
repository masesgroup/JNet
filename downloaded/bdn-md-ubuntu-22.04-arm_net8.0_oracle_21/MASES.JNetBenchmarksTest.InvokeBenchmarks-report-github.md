```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 305.7 ns | 0.09 ns | 0.07 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 268.1 ns | 0.14 ns | 0.13 ns |  0.88 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 524.6 ns | 0.47 ns | 0.42 ns |  1.72 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 331.6 ns | 0.11 ns | 0.10 ns |  1.08 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 536.8 ns | 0.44 ns | 0.39 ns |  1.76 | 0.0048 |     344 B |          NA |
