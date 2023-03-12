namespace Iconic.Transliterator.Conversion
{
    public class GermanToEnglish : IConversion
    {
        /*
         * Taken from stringy PHP library. I am not sure
         * how people transliterate these.
         * https://github.com/danielstjules/Stringy
         */

        public Dictionary<string, string> GetCombinations()
        {
            return new Dictionary<string, string>()
            {
                { "ae", "ä" },
                { "oe", "ö" },
                { "ue", "ü" }
            };
        }

        public string Transform(string input)
        {
            return input;
        }
    }
}
