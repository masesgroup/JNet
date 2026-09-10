```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 270.8 ns | 2.47 ns | 2.19 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 248.9 ns | 1.88 ns | 1.67 ns |  0.92 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 544.2 ns | 2.11 ns | 1.65 ns |  2.01 |    0.02 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 277.7 ns | 1.49 ns | 1.39 ns |  1.03 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 564.6 ns | 2.69 ns | 2.51 ns |  2.08 |    0.02 | 0.0200 |     344 B |          NA |
