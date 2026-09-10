```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.5 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 247.0 ns | 1.74 ns | 1.63 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 253.0 ns | 3.32 ns | 3.11 ns |  1.02 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 483.3 ns | 4.34 ns | 4.06 ns |  1.96 |    0.02 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 249.1 ns | 2.62 ns | 2.45 ns |  1.01 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 495.8 ns | 4.10 ns | 3.63 ns |  2.01 |    0.02 | 0.0181 |     312 B |          NA |
