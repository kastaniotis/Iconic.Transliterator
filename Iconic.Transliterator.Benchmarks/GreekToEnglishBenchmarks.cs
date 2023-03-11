using BenchmarkDotNet.Attributes;
using Iconic.Transliterator.Conversion;

namespace Iconic.Transliterator.Benchmarks
{
    [MemoryDiagnoser]
    public class GreekToEnglishBenchmarks
    {
        int NumberOfItems = 20;
        string greek = "Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία";
        string greeklish = "";

        public GreekToEnglishBenchmarks() 
        {
            for (int i = 0; i < NumberOfItems; i++)
            {
                greeklish += greek;
            }
        }

        [Benchmark]
        public string TestGreekToEnglish()
        {            
            var transliterator = new Transliterator();
            transliterator.AddConversion(new GreekToEnglish());
            return transliterator.Convert(greeklish);
        }

        [Benchmark]
        public string TestGreekToSlug()
        {
            var transliterator = new Transliterator();
            transliterator.AddConversion(new GreekToEnglish());
            transliterator.AddConversion(new EnglishToSlug());
            return transliterator.Convert(greeklish);
        }
    }
}
