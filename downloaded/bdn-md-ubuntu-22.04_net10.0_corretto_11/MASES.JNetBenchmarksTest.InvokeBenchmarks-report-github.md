```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763 2.58GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 423.4 ns | 8.06 ns | 9.28 ns |  1.00 |    0.03 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 360.0 ns | 4.46 ns | 4.17 ns |  0.85 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 682.2 ns | 8.14 ns | 7.22 ns |  1.61 |    0.04 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 419.2 ns | 3.74 ns | 3.32 ns |  0.99 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 702.3 ns | 8.91 ns | 8.34 ns |  1.66 |    0.04 | 0.0181 |     312 B |          NA |
