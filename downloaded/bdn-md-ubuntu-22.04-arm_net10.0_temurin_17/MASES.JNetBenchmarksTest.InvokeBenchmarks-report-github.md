```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 294.6 ns | 0.40 ns | 0.38 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 300.3 ns | 0.20 ns | 0.18 ns |  1.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 548.4 ns | 0.32 ns | 0.28 ns |  1.86 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 305.2 ns | 0.15 ns | 0.14 ns |  1.04 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 554.9 ns | 0.65 ns | 0.57 ns |  1.88 | 0.0038 |     312 B |          NA |
