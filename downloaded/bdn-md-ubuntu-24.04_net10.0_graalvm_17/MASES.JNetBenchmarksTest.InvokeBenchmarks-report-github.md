```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 271.0 ns | 2.41 ns | 2.14 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 265.4 ns | 3.72 ns | 3.30 ns |  0.98 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 530.1 ns | 5.48 ns | 5.12 ns |  1.96 |    0.02 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 274.7 ns | 2.73 ns | 2.56 ns |  1.01 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 540.8 ns | 7.20 ns | 6.01 ns |  2.00 |    0.03 | 0.0181 |     312 B |          NA |
