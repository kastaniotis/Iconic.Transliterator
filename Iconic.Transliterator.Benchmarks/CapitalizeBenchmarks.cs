using BenchmarkDotNet.Attributes;

namespace Iconic.Transliterator.Benchmarks
{
    [ArtifactsPath(@"../../../Results/")]
    [MemoryDiagnoser]
    public class CapitalizeBenchmarks
    {
        private const string Capitalizeme = "capitalizeme";

        [Benchmark]
        public string TestCapitalize()
        {
            return Transliterator.CapitalizeOld(Capitalizeme);
        }

        [Benchmark]
        public string TestCapitalizeSpan()
        {
            return Transliterator.Capitalize(Capitalizeme);
        }
    }
}
