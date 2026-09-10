```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 308.7 ns | 2.41 ns | 2.26 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 255.3 ns | 1.30 ns | 1.15 ns |  0.83 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 553.8 ns | 3.34 ns | 3.12 ns |  1.79 |    0.02 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 282.7 ns | 2.16 ns | 2.02 ns |  0.92 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 531.1 ns | 3.81 ns | 3.38 ns |  1.72 |    0.02 | 0.0200 |     344 B |          NA |
