```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 3.18GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 329.1 ns | 4.91 ns | 4.35 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 328.4 ns | 5.83 ns | 5.17 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 681.2 ns | 9.50 ns | 8.42 ns |  2.07 |    0.04 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 337.0 ns | 6.47 ns | 6.92 ns |  1.02 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 690.9 ns | 7.74 ns | 7.24 ns |  2.10 |    0.03 | 0.0181 |     312 B |          NA |
