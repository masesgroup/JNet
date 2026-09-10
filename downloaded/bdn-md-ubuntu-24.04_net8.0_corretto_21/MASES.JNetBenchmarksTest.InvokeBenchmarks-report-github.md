```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 301.8 ns | 3.17 ns | 2.96 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 266.4 ns | 4.53 ns | 4.24 ns |  0.88 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 627.4 ns | 5.91 ns | 5.24 ns |  2.08 |    0.03 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 314.1 ns | 4.98 ns | 4.66 ns |  1.04 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 596.2 ns | 6.02 ns | 5.64 ns |  1.98 |    0.03 | 0.0200 |     344 B |          NA |
