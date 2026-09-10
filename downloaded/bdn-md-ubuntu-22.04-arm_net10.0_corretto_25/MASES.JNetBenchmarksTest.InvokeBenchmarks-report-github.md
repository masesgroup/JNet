```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 308.2 ns | 0.25 ns | 0.24 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 314.0 ns | 0.31 ns | 0.29 ns |  1.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 558.5 ns | 0.30 ns | 0.23 ns |  1.81 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 319.7 ns | 0.25 ns | 0.23 ns |  1.04 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 557.4 ns | 0.46 ns | 0.41 ns |  1.81 | 0.0038 |     312 B |          NA |
