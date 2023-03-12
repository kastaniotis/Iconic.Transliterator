using System.Text;

namespace Iconic.Transliterator.Conversion
{
    public class GermanToEnglish : ConversionInterface
    {
        /*
         * Taken from stringy PHP library. I am not sure
         * how people transliterate these.
         * https://github.com/danielstjules/Stringy
         */

        public static readonly Dictionary<string, string> Conversions = new Dictionary<string, string>()
        {
                { "ae", "ä" },
                { "oe", "ö" },
                { "ue", "ü" }
        };
        
        public static string Transform(string input)
        {
            return input;
        }
    }
}
