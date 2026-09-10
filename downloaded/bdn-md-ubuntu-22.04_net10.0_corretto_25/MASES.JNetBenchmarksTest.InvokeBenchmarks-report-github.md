```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.63GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 332.5 ns |  6.59 ns |  6.48 ns |  1.00 |    0.03 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 337.1 ns |  2.78 ns |  2.60 ns |  1.01 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 674.1 ns |  8.47 ns |  7.93 ns |  2.03 |    0.04 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 367.5 ns |  7.02 ns |  7.51 ns |  1.11 |    0.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 697.5 ns | 11.59 ns | 10.84 ns |  2.10 |    0.05 | 0.0181 |     312 B |          NA |
