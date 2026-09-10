```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.92GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 261.6 ns | 2.83 ns | 2.65 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 271.6 ns | 2.52 ns | 2.36 ns |  1.04 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 503.2 ns | 2.98 ns | 2.49 ns |  1.92 |    0.02 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 265.4 ns | 2.61 ns | 2.44 ns |  1.01 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 530.9 ns | 6.02 ns | 5.33 ns |  2.03 |    0.03 | 0.0181 |     312 B |          NA |
