using System.Text;

namespace Iconic.Transliterator.Conversion
{
    public class CyrillicToEnglish : IConversion
    {
        /*
         * Added from various sources like wikipedia and
         * other transliteration libraries. 
         * It probably has errors and probably needs
         * more language specific conversions. Please if you
         * can help open an issue on github with your additions, 
         * corrections and examples for testing. Thanks in advance
         */
        public Dictionary<string, string> GetCombinations()
        {
            return new Dictionary<string, string>()
            {
                {"a", "а"},
                {"b", "б"},
                {"v", "в"},
                {"g", "г"},
                {"d", "д"},
                {"e", "еэ"},
                {"zh", "ж"},
                {"z", "з"},
                {"i", "и"},
                {"k", "к"},
                {"l", "л"},
                {"m", "м"},
                {"n", "н"},
                {"o", "о"},
                {"p", "п"},
                {"r", "р"},
                {"s", "с"},
                {"t", "т"},
                {"u", "у"},
                {"f", "ф"},
                {"x", "х"},
                {"ts", "ц"},
                {"sh", "ш"},
                {"shch", "щ"},
                {"ya", "я"},
                {"yu", "ю"},
                {"y", "й"},
                {"ch", "ч"}
            };
        }

        public string Transform(string input)
        {
            return input;
        }
    }
}
