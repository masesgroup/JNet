```

BenchmarkDotNet v0.15.8, Linux Ubuntu 22.04.5 LTS (Jammy Jellyfish)
Intel Xeon 6973P-C 4.10GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.400
  [Host]     : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v4


```
| Method                         | Mean     | Error   | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|--------:|---------:|------:|--------:|-------:|----------:|------------:|
| InvokeStaticEmpty              | 186.7 ns | 1.44 ns |  1.20 ns |  1.00 |    0.01 |      - |         - |          NA |
| InvokeStaticEmptyWithSignature | 187.7 ns | 3.76 ns |  4.33 ns |  1.01 |    0.02 |      - |         - |          NA |
| InvokeStaticWithFeedback       | 372.4 ns | 3.49 ns |  3.09 ns |  1.99 |    0.02 | 0.0033 |     312 B |          NA |
| InvokeInstanceEmpty            | 196.1 ns | 3.80 ns |  4.22 ns |  1.05 |    0.02 |      - |         - |          NA |
| InvokeInstanceWithFeedback     | 388.0 ns | 7.79 ns | 11.66 ns |  2.08 |    0.06 | 0.0033 |     312 B |          NA |
