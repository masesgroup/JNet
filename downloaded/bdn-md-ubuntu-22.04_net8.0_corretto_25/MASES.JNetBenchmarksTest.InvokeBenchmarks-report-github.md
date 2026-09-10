```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.87GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 343.3 ns |  6.56 ns |  6.14 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 313.9 ns |  5.01 ns |  4.44 ns |  0.91 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 696.3 ns | 13.98 ns | 13.08 ns |  2.03 |    0.05 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 353.8 ns |  5.70 ns |  5.33 ns |  1.03 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 698.4 ns | 12.54 ns | 11.73 ns |  2.04 |    0.05 | 0.0200 |     344 B |          NA |
