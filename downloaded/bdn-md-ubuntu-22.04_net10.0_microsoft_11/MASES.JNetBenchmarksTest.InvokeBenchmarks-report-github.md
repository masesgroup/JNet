```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 2.86GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 334.3 ns | 3.01 ns | 2.81 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 338.0 ns | 4.75 ns | 4.45 ns |  1.01 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 609.7 ns | 7.93 ns | 7.03 ns |  1.82 |    0.03 | 0.0181 |     312 B |          NA |
| InvokeInstanceEmpty            | 359.0 ns | 4.41 ns | 3.68 ns |  1.07 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 648.4 ns | 8.41 ns | 7.87 ns |  1.94 |    0.03 | 0.0181 |     312 B |          NA |
