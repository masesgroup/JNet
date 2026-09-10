```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.87GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 310.2 ns |  5.29 ns |  4.95 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 306.1 ns |  5.16 ns |  4.83 ns |  0.99 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 601.7 ns |  7.28 ns |  6.45 ns |  1.94 |    0.04 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 304.5 ns |  5.26 ns |  4.66 ns |  0.98 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 655.3 ns | 11.77 ns | 11.01 ns |  2.11 |    0.05 | 0.0181 |     312 B |          NA |
