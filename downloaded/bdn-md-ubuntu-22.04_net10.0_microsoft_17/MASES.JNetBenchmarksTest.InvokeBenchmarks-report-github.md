```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 9V74 3.69GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 241.2 ns | 3.85 ns | 3.60 ns |  1.00 |    0.02 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 236.8 ns | 3.14 ns | 2.79 ns |  0.98 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 467.2 ns | 5.75 ns | 5.38 ns |  1.94 |    0.04 | 0.0186 |     312 B |          NA |
| InvokeInstanceEmpty            | 229.8 ns | 2.59 ns | 2.29 ns |  0.95 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 480.2 ns | 3.79 ns | 3.36 ns |  1.99 |    0.03 | 0.0181 |     312 B |          NA |
