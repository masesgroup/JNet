```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 267.9 ns | 2.62 ns | 2.32 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 255.5 ns | 4.44 ns | 4.15 ns |  0.95 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 545.6 ns | 8.06 ns | 7.54 ns |  2.04 |    0.03 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 266.5 ns | 2.80 ns | 2.48 ns |  0.99 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 558.0 ns | 4.65 ns | 4.12 ns |  2.08 |    0.02 | 0.0181 |     312 B |          NA |
