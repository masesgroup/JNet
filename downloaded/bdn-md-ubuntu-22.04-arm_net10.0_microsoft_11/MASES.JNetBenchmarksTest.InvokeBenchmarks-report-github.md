```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 380.0 ns | 0.23 ns | 0.22 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 388.3 ns | 0.15 ns | 0.13 ns |  1.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 555.3 ns | 0.48 ns | 0.42 ns |  1.46 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 366.6 ns | 0.25 ns | 0.23 ns |  0.96 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 557.0 ns | 0.58 ns | 0.52 ns |  1.47 | 0.0038 |     312 B |          NA |
