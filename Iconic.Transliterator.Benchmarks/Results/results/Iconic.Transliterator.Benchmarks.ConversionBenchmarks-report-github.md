``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2604/21H2/November2021Update)
AMD Ryzen 7 1700, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.201
  [Host]     : .NET 6.0.14 (6.0.1423.7309), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.14 (6.0.1423.7309), X64 RyuJIT AVX2


```
|           Method |     Mean |    Error |   StdDev |    Gen0 |   Gen1 | Allocated |
|----------------- |---------:|---------:|---------:|--------:|-------:|----------:|
|           V2Init | 73.68 μs | 0.951 μs | 0.843 μs | 12.0850 | 1.4648 |   50704 B |
| V2ConversionSpan | 15.01 μs | 0.169 μs | 0.158 μs |  0.0458 |      - |     192 B |
