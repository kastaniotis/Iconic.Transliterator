``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2604/21H2/November2021Update)
AMD Ryzen 7 1700, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.201
  [Host]     : .NET 6.0.14 (6.0.1423.7309), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.14 (6.0.1423.7309), X64 RyuJIT AVX2


```
|             Method |     Mean |    Error |   StdDev |   Gen0 | Allocated |
|------------------- |---------:|---------:|---------:|-------:|----------:|
|     testCapitalize | 95.06 ns | 1.933 ns | 1.985 ns | 0.0343 |     144 B |
| testCapitalizeSpan | 65.55 ns | 0.190 ns | 0.169 ns | 0.0114 |      48 B |
