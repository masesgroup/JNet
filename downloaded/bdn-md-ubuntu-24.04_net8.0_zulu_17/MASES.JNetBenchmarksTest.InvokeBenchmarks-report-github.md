```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 294.7 ns | 2.63 ns | 2.46 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 280.5 ns | 2.41 ns | 2.25 ns |  0.95 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 606.3 ns | 4.01 ns | 3.75 ns |  2.06 |    0.02 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 314.9 ns | 2.56 ns | 2.40 ns |  1.07 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 586.8 ns | 5.18 ns | 4.59 ns |  1.99 |    0.02 | 0.0200 |     344 B |          NA |
