```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 299.0 ns | 0.21 ns | 0.19 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 303.7 ns | 0.58 ns | 0.54 ns |  1.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 546.0 ns | 0.81 ns | 0.72 ns |  1.83 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 311.7 ns | 0.21 ns | 0.19 ns |  1.04 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 560.9 ns | 0.17 ns | 0.15 ns |  1.88 | 0.0038 |     312 B |          NA |
