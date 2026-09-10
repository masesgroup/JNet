```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 307.8 ns | 0.10 ns | 0.09 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 270.9 ns | 0.08 ns | 0.08 ns |  0.88 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 523.0 ns | 0.69 ns | 0.58 ns |  1.70 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 311.8 ns | 0.11 ns | 0.11 ns |  1.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 534.2 ns | 0.38 ns | 0.32 ns |  1.74 | 0.0048 |     344 B |          NA |
