```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.87GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 348.2 ns |  6.01 ns |  5.62 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 321.2 ns |  6.33 ns |  5.92 ns |  0.92 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 660.7 ns |  9.60 ns |  8.98 ns |  1.90 |    0.04 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 351.3 ns |  4.04 ns |  3.37 ns |  1.01 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 687.2 ns | 12.84 ns | 12.61 ns |  1.97 |    0.05 | 0.0200 |     344 B |          NA |
