```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.87GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 331.6 ns |  5.66 ns |  5.30 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 308.5 ns |  4.30 ns |  4.02 ns |  0.93 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 683.1 ns | 10.96 ns | 10.25 ns |  2.06 |    0.04 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 346.2 ns |  5.88 ns |  5.50 ns |  1.04 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 686.0 ns | 11.27 ns | 10.54 ns |  2.07 |    0.04 | 0.0200 |     344 B |          NA |
