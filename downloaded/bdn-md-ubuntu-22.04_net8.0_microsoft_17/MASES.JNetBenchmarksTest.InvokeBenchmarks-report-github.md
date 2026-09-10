```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V45 4.52GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 171.7 ns | 1.82 ns | 1.52 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 163.5 ns | 3.24 ns | 3.47 ns |  0.95 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 361.5 ns | 5.29 ns | 5.43 ns |  2.11 |    0.04 | 0.0205 |     344 B |          NA |
| InvokeInstanceEmpty            | 176.9 ns | 3.56 ns | 3.16 ns |  1.03 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 374.5 ns | 7.35 ns | 7.54 ns |  2.18 |    0.05 | 0.0205 |     344 B |          NA |
