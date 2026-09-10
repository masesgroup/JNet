```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 312.4 ns | 0.20 ns | 0.19 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 324.2 ns | 0.15 ns | 0.13 ns |  1.04 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 543.6 ns | 0.24 ns | 0.21 ns |  1.74 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 326.7 ns | 0.09 ns | 0.08 ns |  1.05 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 566.9 ns | 0.42 ns | 0.37 ns |  1.81 | 0.0038 |     312 B |          NA |
