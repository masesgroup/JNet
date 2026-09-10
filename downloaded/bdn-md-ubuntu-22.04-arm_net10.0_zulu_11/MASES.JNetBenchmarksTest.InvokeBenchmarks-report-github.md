```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 378.3 ns | 0.18 ns | 0.16 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 388.2 ns | 3.64 ns | 3.23 ns |  1.03 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 543.8 ns | 0.28 ns | 0.25 ns |  1.44 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 390.6 ns | 0.33 ns | 0.30 ns |  1.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 567.4 ns | 0.40 ns | 0.32 ns |  1.50 | 0.0038 |     312 B |          NA |
