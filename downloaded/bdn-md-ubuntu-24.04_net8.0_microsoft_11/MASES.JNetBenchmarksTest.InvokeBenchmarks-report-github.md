```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 362.2 ns | 4.72 ns | 4.41 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 336.9 ns | 3.67 ns | 3.44 ns |  0.93 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 567.5 ns | 5.25 ns | 4.91 ns |  1.57 |    0.02 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 381.8 ns | 3.74 ns | 3.50 ns |  1.05 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 624.5 ns | 5.62 ns | 4.98 ns |  1.72 |    0.02 | 0.0200 |     344 B |          NA |
