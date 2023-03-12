namespace Iconic.Transliterator.Conversion
{
    public class EnglishToSlug : IConversion
    {
        public Dictionary<string, string> GetCombinations()            
        {
            return new Dictionary<string, string> {
                { " ", "  " },
                { "-", " " }
            };
        }
        
        public string Transform(string input)
        {
            return input.ToLower();
        }
    }
}
