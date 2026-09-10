```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.75GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 318.9 ns | 4.98 ns | 4.66 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 319.1 ns | 4.58 ns | 3.83 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 676.2 ns | 7.10 ns | 6.29 ns |  2.12 |    0.04 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 341.6 ns | 2.98 ns | 2.79 ns |  1.07 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 691.2 ns | 7.83 ns | 6.54 ns |  2.17 |    0.04 | 0.0181 |     312 B |          NA |
