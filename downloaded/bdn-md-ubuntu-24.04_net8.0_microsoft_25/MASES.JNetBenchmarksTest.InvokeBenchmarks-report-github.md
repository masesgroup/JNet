```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 288.3 ns | 4.14 ns | 3.87 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 273.9 ns | 4.57 ns | 4.05 ns |  0.95 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 602.4 ns | 5.38 ns | 4.77 ns |  2.09 |    0.03 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 306.6 ns | 2.01 ns | 1.88 ns |  1.06 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 617.7 ns | 5.12 ns | 4.79 ns |  2.14 |    0.03 | 0.0200 |     344 B |          NA |
