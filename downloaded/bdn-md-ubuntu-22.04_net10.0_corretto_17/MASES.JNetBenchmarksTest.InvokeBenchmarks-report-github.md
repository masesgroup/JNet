```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.69GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 345.3 ns |  5.26 ns |  4.92 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 319.3 ns |  4.37 ns |  3.65 ns |  0.92 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 679.8 ns | 13.58 ns | 12.70 ns |  1.97 |    0.04 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 344.1 ns |  4.81 ns |  4.02 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 682.7 ns |  7.71 ns |  7.21 ns |  1.98 |    0.03 | 0.0181 |     312 B |          NA |
