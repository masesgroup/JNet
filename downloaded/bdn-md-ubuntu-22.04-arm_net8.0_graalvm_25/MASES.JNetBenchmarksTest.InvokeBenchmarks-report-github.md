```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 310.7 ns | 0.11 ns | 0.11 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 274.2 ns | 0.15 ns | 0.14 ns |  0.88 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 529.2 ns | 0.37 ns | 0.33 ns |  1.70 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 315.5 ns | 0.16 ns | 0.14 ns |  1.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 548.5 ns | 0.67 ns | 0.62 ns |  1.77 | 0.0048 |     344 B |          NA |
