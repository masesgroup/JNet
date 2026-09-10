```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 302.4 ns | 0.14 ns | 0.13 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 273.9 ns | 0.10 ns | 0.09 ns |  0.91 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 539.7 ns | 0.68 ns | 0.61 ns |  1.78 | 0.0048 |     344 B |          NA |
| InvokeInstanceEmpty            | 319.9 ns | 0.08 ns | 0.08 ns |  1.06 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 554.4 ns | 0.37 ns | 0.33 ns |  1.83 | 0.0048 |     344 B |          NA |
