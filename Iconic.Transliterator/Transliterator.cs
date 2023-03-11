using Iconic.Transliterator.Conversion;

namespace Iconic.Transliterator
{
    public class Transliterator
    {
        private List<ConversionInterface> conversions;
        public Transliterator() {
            conversions = new List<ConversionInterface>();
        }

        public void AddConversion(ConversionInterface conversion)
        {
            this.conversions.Add(conversion);
        }

        // TODO: Check if conversions can be done more efficiently than using just strings
        public string Convert(string text)
        {
            foreach (ConversionInterface conversion in conversions)
            {
                text = conversion.Transform(text);

                foreach(var combination in conversion.GetCombinations()) 
                {
                    foreach(var option in combination.Value.Split(","))
                    {
                        text = text.Replace(option.ToLower(), combination.Key.ToLower()); //Lowercase
                        text = text.Replace(option.ToUpper(), combination.Key.ToUpper()); //All Caps
                        text = text.Replace(Capitalize(option), Capitalize(combination.Key)); //Capitalized
                    }
                }

                //TODO: Letters should be split with comma to keep things consistent
                foreach (var combination in conversion.GetLetters())
                {
                    foreach (var option in combination.Value.ToCharArray())
                    {
                        text = text.Replace(option.ToString().ToLower(), combination.Key.ToLower()); //Lowercase
                        text = text.Replace(option.ToString().ToUpper(), combination.Key.ToUpper()); //All Caps
                    }
                }

                foreach (var combination in conversion.GetDuals())
                {
                    foreach (var option in combination.Value.ToCharArray())
                    {
                        text = text.Replace(option.ToString().ToLower(), combination.Key.ToLower()); //Lowercase
                        text = text.Replace(option.ToString().ToUpper(), combination.Key.ToUpper()); //All Caps
                    }
                }
            }

            return text;
        }

        public static string Capitalize(string text)
        {
            return text[0].ToString().ToUpper() + text[1..].ToLower();
        }
    }
}
