```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 246.2 ns | 2.69 ns | 2.25 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 265.0 ns | 3.47 ns | 3.25 ns |  1.08 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 549.2 ns | 5.34 ns | 5.00 ns |  2.23 |    0.03 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 282.4 ns | 1.49 ns | 1.32 ns |  1.15 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 552.8 ns | 4.48 ns | 4.19 ns |  2.25 |    0.03 | 0.0181 |     312 B |          NA |
