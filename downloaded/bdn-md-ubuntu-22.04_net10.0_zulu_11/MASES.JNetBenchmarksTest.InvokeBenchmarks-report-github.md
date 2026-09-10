```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.86GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 336.6 ns | 4.47 ns | 4.18 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 357.2 ns | 6.25 ns | 5.54 ns |  1.06 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 626.4 ns | 8.46 ns | 7.92 ns |  1.86 |    0.03 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 363.0 ns | 6.24 ns | 5.83 ns |  1.08 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 629.2 ns | 6.15 ns | 5.13 ns |  1.87 |    0.03 | 0.0181 |     312 B |          NA |
