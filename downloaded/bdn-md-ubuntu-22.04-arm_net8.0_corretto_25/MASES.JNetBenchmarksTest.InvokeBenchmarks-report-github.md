```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 311.2 ns | 0.09 ns | 0.09 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 273.3 ns | 0.09 ns | 0.09 ns |  0.88 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 539.7 ns | 0.53 ns | 0.47 ns |  1.73 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 313.9 ns | 0.09 ns | 0.09 ns |  1.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 561.1 ns | 0.54 ns | 0.50 ns |  1.80 | 0.0048 |     344 B |          NA |
