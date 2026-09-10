```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 298.2 ns | 4.13 ns | 3.86 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 264.2 ns | 2.55 ns | 2.39 ns |  0.89 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 588.3 ns | 5.96 ns | 4.65 ns |  1.97 |    0.03 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 310.6 ns | 3.69 ns | 3.45 ns |  1.04 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 621.5 ns | 4.89 ns | 4.58 ns |  2.08 |    0.03 | 0.0200 |     344 B |          NA |
