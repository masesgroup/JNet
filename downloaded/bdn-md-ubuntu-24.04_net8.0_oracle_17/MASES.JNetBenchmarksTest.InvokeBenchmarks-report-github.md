```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 298.6 ns | 3.44 ns | 3.22 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 263.3 ns | 3.97 ns | 3.71 ns |  0.88 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 581.3 ns | 8.20 ns | 7.67 ns |  1.95 |    0.03 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 295.9 ns | 3.22 ns | 3.01 ns |  0.99 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 602.4 ns | 5.80 ns | 5.42 ns |  2.02 |    0.03 | 0.0200 |     344 B |          NA |
