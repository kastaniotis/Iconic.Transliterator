namespace Iconic.Transliterator.Conversion
{
    public interface ConversionInterface
    {
        public Dictionary<string, string> GetCombinations();
        public Dictionary<string, string> GetLetters();
        public Dictionary<string, string> GetDuals();
        public string Transform(string input);
    }
}
