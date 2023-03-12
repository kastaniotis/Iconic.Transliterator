using System.Text;

namespace Iconic.Transliterator.Conversion
{
    public interface ConversionInterface
    {
        public static Dictionary<string, string> Combinations { get; set; }
        public static string Transform(string input) => input;
    }
}
