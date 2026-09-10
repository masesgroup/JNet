```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 3.65GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 229.9 ns | 2.60 ns | 2.43 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 233.5 ns | 2.79 ns | 2.61 ns |  1.02 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 462.0 ns | 5.80 ns | 5.14 ns |  2.01 |    0.03 | 0.0186 |     312 B |          NA |
| InvokeInstanceEmpty            | 237.9 ns | 3.24 ns | 3.03 ns |  1.03 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 468.7 ns | 8.30 ns | 7.76 ns |  2.04 |    0.04 | 0.0186 |     312 B |          NA |
