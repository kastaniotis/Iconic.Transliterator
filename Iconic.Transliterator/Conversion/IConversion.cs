using System.Text;

namespace Iconic.Transliterator.Conversion
{
    public interface IConversion
    {
        public Dictionary<string, string> GetCombinations();
        public string Transform(string input);
    }
}
