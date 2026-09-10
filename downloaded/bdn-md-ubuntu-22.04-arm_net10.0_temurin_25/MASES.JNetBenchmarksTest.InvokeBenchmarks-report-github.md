```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 307.9 ns | 0.29 ns | 0.27 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 305.6 ns | 0.18 ns | 0.17 ns |  0.99 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 553.3 ns | 0.35 ns | 0.31 ns |  1.80 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 324.4 ns | 0.21 ns | 0.19 ns |  1.05 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 567.1 ns | 0.55 ns | 0.49 ns |  1.84 | 0.0038 |     312 B |          NA |
