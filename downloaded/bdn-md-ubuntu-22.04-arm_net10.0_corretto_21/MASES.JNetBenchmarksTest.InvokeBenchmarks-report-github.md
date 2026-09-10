```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 313.7 ns | 0.22 ns | 0.21 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 320.3 ns | 0.06 ns | 0.05 ns |  1.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 541.9 ns | 0.32 ns | 0.29 ns |  1.73 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 320.2 ns | 0.21 ns | 0.19 ns |  1.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 566.2 ns | 0.24 ns | 0.21 ns |  1.81 | 0.0038 |     312 B |          NA |
