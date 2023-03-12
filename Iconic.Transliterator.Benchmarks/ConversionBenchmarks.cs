using BenchmarkDotNet.Attributes;
using Iconic.Transliterator.Conversion;

namespace Iconic.Transliterator.Benchmarks
{
    [ArtifactsPath(@"../../../Results/")]
    [MemoryDiagnoser]
    public class ConversionBenchmarks
    {
        private readonly Transliterator _transliterator2;
        //string toReplace = "Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία ";
        string toReplace = "Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία";
        public ConversionBenchmarks() 
        {
            _transliterator2 = new Transliterator();
            _transliterator2.AddConversions(new GreekToEnglish());
            _transliterator2.AddConversions(new EnglishToSlug());
        }

        [Benchmark]
        public void V2Init()
        {
            var converter = new Transliterator();
            converter.AddConversions(new GreekToEnglish());
            converter.AddConversions(new EnglishToSlug());
        }

        [Benchmark]
        public string V2ConversionSpan()
        {
            var result = _transliterator2.Convert(toReplace);
            
            return result;
        }
    }

}
