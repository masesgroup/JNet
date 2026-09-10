```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 303.9 ns | 0.10 ns | 0.10 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 308.9 ns | 0.20 ns | 0.19 ns |  1.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 554.2 ns | 0.41 ns | 0.36 ns |  1.82 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 316.0 ns | 0.19 ns | 0.18 ns |  1.04 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 552.0 ns | 0.54 ns | 0.48 ns |  1.82 | 0.0038 |     312 B |          NA |
