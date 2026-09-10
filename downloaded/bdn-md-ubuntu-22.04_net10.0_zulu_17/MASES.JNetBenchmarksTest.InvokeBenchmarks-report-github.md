```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.86GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 304.2 ns | 3.21 ns | 2.68 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 318.8 ns | 3.57 ns | 3.34 ns |  1.05 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 627.8 ns | 9.61 ns | 8.99 ns |  2.06 |    0.03 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 309.2 ns | 4.65 ns | 4.12 ns |  1.02 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 618.2 ns | 2.87 ns | 2.40 ns |  2.03 |    0.02 | 0.0181 |     312 B |          NA |
