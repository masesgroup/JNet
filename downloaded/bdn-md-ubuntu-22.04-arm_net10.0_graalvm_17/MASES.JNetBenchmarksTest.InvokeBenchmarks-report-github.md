```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 306.1 ns | 0.24 ns | 0.23 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 306.6 ns | 0.32 ns | 0.30 ns |  1.00 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 573.6 ns | 0.32 ns | 0.29 ns |  1.87 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 322.1 ns | 0.18 ns | 0.17 ns |  1.05 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 565.4 ns | 0.66 ns | 0.59 ns |  1.85 | 0.0038 |     312 B |          NA |
