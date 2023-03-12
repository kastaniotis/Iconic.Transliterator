using System.Text;

namespace Iconic.Transliterator.Conversion
{
    public class EnglishToSlug : ConversionInterface
    {
        public static readonly Dictionary<string, string> Conversions = new Dictionary<string, string>()
        {
            { "-", " " }
        };

        public static string Transform(string input)
        {
            return input.Trim().ToLower();
        }
    }
}
