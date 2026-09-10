```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 304.9 ns | 0.10 ns | 0.08 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 318.8 ns | 1.72 ns | 1.61 ns |  1.05 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 535.7 ns | 0.50 ns | 0.44 ns |  1.76 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 315.2 ns | 0.08 ns | 0.08 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 550.3 ns | 0.56 ns | 0.46 ns |  1.81 | 0.0038 |     312 B |          NA |
