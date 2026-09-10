```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 261.3 ns | 4.06 ns | 3.80 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 259.5 ns | 1.63 ns | 1.52 ns |  0.99 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 542.0 ns | 4.50 ns | 3.99 ns |  2.07 |    0.03 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 268.4 ns | 3.15 ns | 2.94 ns |  1.03 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 542.3 ns | 7.05 ns | 6.59 ns |  2.08 |    0.04 | 0.0181 |     312 B |          NA |
