namespace Iconic.Transliterator.Conversion
{
    public class GermanToEnglish : ConversionInterface
    {
        /*
         * Taken from stringify PHP library. I am not sure
         * how people transliterate these.
         * https://github.com/danielstjules/Stringy
         */

        public Dictionary<string, string> GetCombinations()
        {
            return new Dictionary<string, string>();
        }

        public Dictionary<string, string> GetDuals()
        {
            return new Dictionary<string, string>()
            {
                { "ae", "ä" },
                { "oe", "ö" },
                { "ue", "ü" }
            };
        }
        
        public Dictionary<string, string> GetLetters()
        {
            return new Dictionary<string, string>()
            {
                { "s", "ß" }
            };
        }

        public string Transform(string input)
        {
            return input;
        }
    }
}
