```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 308.8 ns | 0.15 ns | 0.13 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 311.7 ns | 0.28 ns | 0.26 ns |  1.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 548.6 ns | 0.47 ns | 0.42 ns |  1.78 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 322.5 ns | 0.24 ns | 0.22 ns |  1.04 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 569.6 ns | 0.29 ns | 0.26 ns |  1.84 | 0.0038 |     312 B |          NA |
