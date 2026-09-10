```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 271.8 ns | 1.73 ns | 1.54 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 252.6 ns | 2.17 ns | 2.03 ns |  0.93 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 523.3 ns | 5.49 ns | 4.59 ns |  1.93 |    0.02 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 281.6 ns | 2.24 ns | 1.87 ns |  1.04 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 537.6 ns | 3.23 ns | 3.02 ns |  1.98 |    0.02 | 0.0200 |     344 B |          NA |
