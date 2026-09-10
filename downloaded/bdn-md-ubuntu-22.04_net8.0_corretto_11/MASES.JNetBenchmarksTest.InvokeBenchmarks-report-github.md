```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 3.14GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 426.8 ns |  5.56 ns |  5.20 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 387.9 ns |  7.76 ns |  7.62 ns |  0.91 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 690.9 ns | 12.90 ns | 12.07 ns |  1.62 |    0.03 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 428.7 ns |  5.67 ns |  5.03 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 748.6 ns | 13.97 ns | 13.07 ns |  1.75 |    0.04 | 0.0200 |     344 B |          NA |
