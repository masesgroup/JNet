```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 308.8 ns | 0.12 ns | 0.12 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 314.0 ns | 0.33 ns | 0.31 ns |  1.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 552.3 ns | 0.29 ns | 0.25 ns |  1.79 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 320.0 ns | 0.15 ns | 0.13 ns |  1.04 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 571.4 ns | 0.45 ns | 0.40 ns |  1.85 | 0.0038 |     312 B |          NA |
