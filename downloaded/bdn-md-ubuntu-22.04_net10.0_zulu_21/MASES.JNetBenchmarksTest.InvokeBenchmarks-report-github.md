```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.85GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 300.6 ns |  4.24 ns | 3.96 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 301.9 ns |  3.43 ns | 3.20 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 612.0 ns |  5.47 ns | 5.11 ns |  2.04 |    0.03 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 301.6 ns |  1.88 ns | 1.67 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 600.4 ns | 10.15 ns | 9.49 ns |  2.00 |    0.04 | 0.0181 |     312 B |          NA |
