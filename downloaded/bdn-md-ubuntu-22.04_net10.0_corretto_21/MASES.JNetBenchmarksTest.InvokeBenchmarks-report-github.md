```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Intel Xeon Platinum 8370C CPU 2.80GHz (Max: 3.33GHz), 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 321.7 ns | 2.77 ns | 2.46 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 327.3 ns | 3.38 ns | 3.16 ns |  1.02 |    0.01 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 613.9 ns | 6.33 ns | 5.92 ns |  1.91 |    0.02 | 0.0124 |     312 B |          NA |
| InvokeInstanceEmpty            | 326.3 ns | 3.12 ns | 2.92 ns |  1.01 |    0.01 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 619.2 ns | 3.67 ns | 3.07 ns |  1.92 |    0.02 | 0.0124 |     312 B |          NA |
