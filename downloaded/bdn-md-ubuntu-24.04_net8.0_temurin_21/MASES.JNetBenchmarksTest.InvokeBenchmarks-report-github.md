```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 291.2 ns | 3.17 ns | 2.81 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 264.6 ns | 2.60 ns | 2.43 ns |  0.91 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 607.9 ns | 5.29 ns | 4.95 ns |  2.09 |    0.03 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 303.3 ns | 2.67 ns | 2.50 ns |  1.04 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 610.6 ns | 5.71 ns | 5.34 ns |  2.10 |    0.03 | 0.0200 |     344 B |          NA |
