```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 190.7 ns | 2.32 ns | 2.06 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 191.6 ns | 2.50 ns | 2.22 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 364.1 ns | 4.65 ns | 4.35 ns |  1.91 |    0.03 | 0.0033 |     312 B |          NA |
| InvokeInstanceEmpty            | 202.7 ns | 2.55 ns | 2.26 ns |  1.06 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 380.2 ns | 6.09 ns | 5.70 ns |  1.99 |    0.04 | 0.0033 |     312 B |          NA |
