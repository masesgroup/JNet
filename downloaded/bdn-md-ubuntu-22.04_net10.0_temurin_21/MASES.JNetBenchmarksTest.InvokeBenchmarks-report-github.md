```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 3.69GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 225.3 ns | 3.18 ns | 2.98 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 227.2 ns | 3.03 ns | 2.84 ns |  1.01 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 471.8 ns | 4.28 ns | 3.57 ns |  2.09 |    0.03 | 0.0186 |     312 B |          NA |
| InvokeInstanceEmpty            | 229.2 ns | 3.70 ns | 3.46 ns |  1.02 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 476.5 ns | 6.30 ns | 5.90 ns |  2.12 |    0.04 | 0.0181 |     312 B |          NA |
