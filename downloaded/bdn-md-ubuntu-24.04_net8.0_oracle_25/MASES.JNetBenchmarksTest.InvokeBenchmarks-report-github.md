```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 299.5 ns | 2.93 ns | 2.74 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 275.6 ns | 2.98 ns | 2.49 ns |  0.92 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 576.6 ns | 8.16 ns | 7.64 ns |  1.93 |    0.03 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 308.6 ns | 4.87 ns | 4.56 ns |  1.03 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 603.7 ns | 5.45 ns | 5.10 ns |  2.02 |    0.02 | 0.0200 |     344 B |          NA |
