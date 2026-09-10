```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 311.6 ns | 0.18 ns | 0.16 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 325.0 ns | 0.24 ns | 0.23 ns |  1.04 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 559.3 ns | 0.35 ns | 0.31 ns |  1.80 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 326.6 ns | 0.11 ns | 0.10 ns |  1.05 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 559.0 ns | 0.40 ns | 0.36 ns |  1.79 | 0.0038 |     312 B |          NA |
