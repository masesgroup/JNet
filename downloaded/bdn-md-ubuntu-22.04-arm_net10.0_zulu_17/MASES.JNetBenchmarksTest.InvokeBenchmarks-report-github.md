```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 311.2 ns | 0.13 ns | 0.12 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 312.9 ns | 0.42 ns | 0.39 ns |  1.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 570.2 ns | 0.44 ns | 0.39 ns |  1.83 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 319.2 ns | 0.32 ns | 0.29 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 584.8 ns | 0.42 ns | 0.35 ns |  1.88 | 0.0038 |     312 B |          NA |
