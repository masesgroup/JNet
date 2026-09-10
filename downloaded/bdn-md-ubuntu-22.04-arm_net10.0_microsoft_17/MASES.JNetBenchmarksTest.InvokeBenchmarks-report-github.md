```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 297.2 ns | 0.21 ns | 0.19 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 298.6 ns | 0.39 ns | 0.36 ns |  1.00 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 545.6 ns | 0.42 ns | 0.37 ns |  1.84 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 306.1 ns | 0.15 ns | 0.14 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 556.0 ns | 0.71 ns | 0.67 ns |  1.87 | 0.0038 |     312 B |          NA |
