```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 337.3 ns | 2.44 ns | 2.29 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 304.8 ns | 1.21 ns | 1.07 ns |  0.90 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 569.8 ns | 5.28 ns | 4.68 ns |  1.69 |    0.02 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 367.3 ns | 2.58 ns | 2.29 ns |  1.09 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 555.8 ns | 3.59 ns | 3.36 ns |  1.65 |    0.01 | 0.0200 |     344 B |          NA |
