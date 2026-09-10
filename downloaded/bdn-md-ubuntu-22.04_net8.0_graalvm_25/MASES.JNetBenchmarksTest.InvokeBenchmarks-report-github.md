```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.87GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 338.3 ns |  3.72 ns |  3.48 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 316.2 ns |  5.12 ns |  4.79 ns |  0.93 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 665.1 ns |  8.50 ns |  7.95 ns |  1.97 |    0.03 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 342.7 ns |  3.24 ns |  2.88 ns |  1.01 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 701.5 ns | 12.32 ns | 11.52 ns |  2.07 |    0.04 | 0.0200 |     344 B |          NA |
