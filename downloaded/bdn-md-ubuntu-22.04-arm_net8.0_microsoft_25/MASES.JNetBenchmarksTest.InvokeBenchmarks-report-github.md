```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 305.0 ns | 0.15 ns | 0.14 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 269.1 ns | 0.19 ns | 0.17 ns |  0.88 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 530.5 ns | 0.37 ns | 0.33 ns |  1.74 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 311.7 ns | 0.11 ns | 0.11 ns |  1.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 553.3 ns | 0.43 ns | 0.38 ns |  1.81 | 0.0048 |     344 B |          NA |
