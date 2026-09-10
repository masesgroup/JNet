```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 375.2 ns | 0.20 ns | 0.19 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 355.2 ns | 0.21 ns | 0.20 ns |  0.95 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 541.7 ns | 0.78 ns | 0.73 ns |  1.44 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 404.0 ns | 0.45 ns | 0.42 ns |  1.08 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 555.8 ns | 0.47 ns | 0.41 ns |  1.48 | 0.0048 |     344 B |          NA |
