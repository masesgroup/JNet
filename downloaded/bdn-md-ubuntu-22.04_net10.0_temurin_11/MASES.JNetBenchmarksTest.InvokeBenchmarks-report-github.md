```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 402.9 ns |  5.62 ns |  5.26 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 400.2 ns |  7.69 ns |  7.55 ns |  0.99 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 686.8 ns | 13.43 ns | 13.19 ns |  1.70 |    0.04 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 429.8 ns |  8.30 ns |  7.76 ns |  1.07 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 681.0 ns | 10.75 ns | 10.05 ns |  1.69 |    0.03 | 0.0181 |     312 B |          NA |
