```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 307.1 ns | 0.29 ns | 0.24 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 311.6 ns | 0.19 ns | 0.18 ns |  1.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 572.8 ns | 0.38 ns | 0.32 ns |  1.87 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 320.0 ns | 0.24 ns | 0.21 ns |  1.04 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 574.3 ns | 1.18 ns | 1.10 ns |  1.87 | 0.0038 |     312 B |          NA |
