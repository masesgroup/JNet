```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.46GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 333.5 ns | 3.99 ns | 3.54 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 303.5 ns | 1.35 ns | 1.26 ns |  0.91 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 600.8 ns | 4.98 ns | 4.41 ns |  1.80 |    0.02 | 0.0200 |     344 B |          NA |
| InvokeInstanceEmpty            | 329.0 ns | 1.47 ns | 1.30 ns |  0.99 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 636.0 ns | 3.49 ns | 2.92 ns |  1.91 |    0.02 | 0.0200 |     344 B |          NA |
