```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 380.7 ns | 0.17 ns | 0.15 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 385.7 ns | 0.25 ns | 0.24 ns |  1.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 553.1 ns | 0.37 ns | 0.33 ns |  1.45 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 380.9 ns | 0.13 ns | 0.13 ns |  1.00 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 552.2 ns | 0.47 ns | 0.40 ns |  1.45 | 0.0038 |     312 B |          NA |
