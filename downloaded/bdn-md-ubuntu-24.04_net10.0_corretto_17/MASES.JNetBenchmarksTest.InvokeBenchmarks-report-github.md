```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 7763 3.14GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 273.6 ns | 3.50 ns | 3.27 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 265.6 ns | 1.27 ns | 1.19 ns |  0.97 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 549.2 ns | 4.97 ns | 4.65 ns |  2.01 |    0.03 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 282.8 ns | 3.99 ns | 3.73 ns |  1.03 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 562.6 ns | 5.69 ns | 5.32 ns |  2.06 |    0.03 | 0.0181 |     312 B |          NA |
