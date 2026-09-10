```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Unknown processor, 4 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), Arm64 RyuJIT armv8.0-a


```
| Method                         | Mean     | Error   | StdDev  | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 306.5 ns | 0.14 ns | 0.13 ns |  1.00 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 309.7 ns | 0.14 ns | 0.12 ns |  1.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 531.2 ns | 0.30 ns | 0.27 ns |  1.73 | 0.0038 |     312 B |          NA |
| InvokeInstanceEmpty            | 331.4 ns | 0.20 ns | 0.19 ns |  1.08 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 548.2 ns | 0.40 ns | 0.36 ns |  1.79 | 0.0038 |     312 B |          NA |
