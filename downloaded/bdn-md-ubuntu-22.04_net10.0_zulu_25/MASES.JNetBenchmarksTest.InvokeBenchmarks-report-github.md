```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 348.2 ns |  7.01 ns |  7.79 ns |  1.00 |    0.03 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 313.7 ns |  4.03 ns |  3.36 ns |  0.90 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 673.8 ns | 10.83 ns | 12.04 ns |  1.94 |    0.05 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 341.6 ns |  6.46 ns |  6.34 ns |  0.98 |    0.03 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 733.0 ns | 12.38 ns | 11.58 ns |  2.11 |    0.06 | 0.0181 |     312 B |          NA |
