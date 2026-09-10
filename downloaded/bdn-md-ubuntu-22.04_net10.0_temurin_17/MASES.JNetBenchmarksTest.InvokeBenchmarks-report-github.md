```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 3.19GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 320.8 ns | 6.36 ns | 5.95 ns |  1.00 |    0.03 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 323.6 ns | 5.35 ns | 5.00 ns |  1.01 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 662.7 ns | 9.05 ns | 8.03 ns |  2.07 |    0.04 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 317.1 ns | 5.27 ns | 4.93 ns |  0.99 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 686.8 ns | 5.98 ns | 5.30 ns |  2.14 |    0.04 | 0.0181 |     312 B |          NA |
