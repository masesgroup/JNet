```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 3.69GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 189.3 ns | 1.12 ns | 1.05 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 189.2 ns | 1.03 ns | 0.91 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 383.5 ns | 1.09 ns | 0.97 ns |  2.03 |    0.01 | 0.0186 |     312 B |          NA |
| InvokeInstanceEmpty            | 192.7 ns | 0.96 ns | 0.89 ns |  1.02 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 384.2 ns | 3.08 ns | 2.73 ns |  2.03 |    0.02 | 0.0186 |     312 B |          NA |
