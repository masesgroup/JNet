```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 305.4 ns | 0.26 ns | 0.24 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 309.9 ns | 0.14 ns | 0.13 ns |  1.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 546.5 ns | 0.27 ns | 0.22 ns |  1.79 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 320.3 ns | 0.25 ns | 0.23 ns |  1.05 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 563.5 ns | 0.50 ns | 0.45 ns |  1.84 | 0.0038 |     312 B |          NA |
