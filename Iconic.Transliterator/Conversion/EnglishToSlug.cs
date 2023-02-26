namespace Iconic.Transliterator.Conversion
{
    public class EnglishToSlug : ConversionInterface
    {
        public Dictionary<string, string> GetCombinations()
        {
            return new Dictionary<string, string>
            {
                { " ", "  " }
            };
        }

        public Dictionary<string, string> GetDuals()
        {
            return new Dictionary<string, string>
            {
                
            };
        }

        public Dictionary<string, string> GetLetters()
        {
            return new Dictionary<string, string>
            {
                { "-", " " }
            };
        }

        public string Transform(string input)
        {
            return input.Trim().ToLower();
        }
    }
}
