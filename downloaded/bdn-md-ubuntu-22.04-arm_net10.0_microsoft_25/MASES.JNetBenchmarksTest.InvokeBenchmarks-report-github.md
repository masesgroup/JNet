```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 297.4 ns | 0.15 ns | 0.14 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 302.7 ns | 0.21 ns | 0.20 ns |  1.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 554.8 ns | 1.18 ns | 1.10 ns |  1.87 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 316.7 ns | 0.30 ns | 0.26 ns |  1.07 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 565.0 ns | 0.22 ns | 0.19 ns |  1.90 | 0.0038 |     312 B |          NA |
