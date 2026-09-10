```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 302.0 ns | 3.91 ns | 3.66 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 284.0 ns | 2.30 ns | 2.15 ns |  0.94 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 601.8 ns | 3.33 ns | 3.12 ns |  1.99 |    0.03 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 313.9 ns | 2.66 ns | 2.49 ns |  1.04 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 605.1 ns | 5.65 ns | 5.29 ns |  2.00 |    0.03 | 0.0200 |     344 B |          NA |
