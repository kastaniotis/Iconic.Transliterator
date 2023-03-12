using BenchmarkDotNet.Attributes;
using Iconic.Transliterator.Conversion;

namespace Iconic.Transliterator.Benchmarks
{
    [MemoryDiagnoser]
    public class ConversionBenchmarks
    {
        Transliterator transliterator2;
        string toReplace = "Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία ";
        public ConversionBenchmarks() 
        {
            transliterator2 = new Transliterator();
            transliterator2.AddConversions(typeof(GreekToEnglish));
            transliterator2.AddConversions(typeof(EnglishToSlug));
        }

        [Benchmark]
        public void V2Init()
        {
            var converter = new Transliterator();
            converter.AddConversions(typeof(GreekToEnglish));
            converter.AddConversions(typeof(EnglishToSlug));
        }

        [Benchmark]
        public string V2Conversion()
        {
            return transliterator2.Convert(toReplace);
        }

        [Benchmark]
        public string V2ConversionSpan()
        {
            var result = transliterator2.ConvertSpan(toReplace);
            
            return result;
        }
    }

}
