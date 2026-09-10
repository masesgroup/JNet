```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.70GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 328.2 ns |  2.39 ns |  2.12 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 330.8 ns |  2.96 ns |  2.62 ns |  1.01 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 655.2 ns | 11.50 ns | 10.76 ns |  2.00 |    0.03 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 331.1 ns |  6.47 ns |  7.46 ns |  1.01 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 708.2 ns | 12.35 ns | 11.55 ns |  2.16 |    0.04 | 0.0181 |     312 B |          NA |
