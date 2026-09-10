```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 313.5 ns | 0.13 ns | 0.12 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 277.0 ns | 0.14 ns | 0.13 ns |  0.88 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 548.6 ns | 0.62 ns | 0.55 ns |  1.75 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 320.1 ns | 0.09 ns | 0.08 ns |  1.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 548.5 ns | 1.33 ns | 1.25 ns |  1.75 | 0.0048 |     344 B |          NA |
