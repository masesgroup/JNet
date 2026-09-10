```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.59GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 328.1 ns |  6.63 ns |  7.09 ns |  1.00 |    0.03 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 321.1 ns |  4.30 ns |  4.02 ns |  0.98 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 659.8 ns |  5.65 ns |  5.01 ns |  2.01 |    0.04 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 338.7 ns |  5.33 ns |  4.98 ns |  1.03 |    0.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 683.0 ns | 13.27 ns | 13.03 ns |  2.08 |    0.06 | 0.0181 |     312 B |          NA |
