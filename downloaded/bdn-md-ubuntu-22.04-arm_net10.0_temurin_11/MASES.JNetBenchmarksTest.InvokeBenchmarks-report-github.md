```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 371.5 ns | 0.20 ns | 0.18 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 375.5 ns | 0.23 ns | 0.20 ns |  1.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 553.2 ns | 0.39 ns | 0.30 ns |  1.49 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 400.5 ns | 0.23 ns | 0.21 ns |  1.08 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 567.5 ns | 0.23 ns | 0.20 ns |  1.53 | 0.0038 |     312 B |          NA |
