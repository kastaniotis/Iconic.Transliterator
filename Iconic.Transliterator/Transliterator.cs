using Iconic.Transliterator.Conversion;

namespace Iconic.Transliterator
{
    public class Transliterator
    {
        private List<IConversion> _conversions = new();
        private Dictionary<string, string> _combinations = new();

        public void AddConversions(IConversion conversion) 
        {
            _conversions.Add(conversion);
            foreach (var combination in conversion.GetCombinations()) 
            {
                foreach (var current in combination.Value.Split(","))
                {
                    _combinations.Add(current, combination.Key);
                    _combinations.TryAdd(current.ToUpper(), combination.Key.ToUpper());
                    _combinations.TryAdd(Capitalize(current), Capitalize(combination.Key));
                }
            }
            _combinations = _combinations.OrderByDescending(i => i.Key.Length).ToDictionary(i => i.Key, i => i.Value);
        }

        public string Convert(string text)
        {
            // TODO: This one is awful. Make the Conversion objects again. Cheaper to call the actions.     
            Span<char> textSpan = stackalloc char[1];
            foreach (var conversion in _conversions)
            {
                var tempSpan = conversion.Transform(text).AsSpan();
                textSpan = stackalloc char[tempSpan.Length];
                tempSpan.CopyTo(textSpan);
            }

            Span<char> resultSpan = stackalloc char[textSpan.Trim().Length];
            textSpan.Trim().CopyTo(resultSpan);
            int occurence = -1;
            
            foreach (var combination in _combinations)
            {
                occurence = resultSpan.IndexOf(combination.Key);
                while (occurence > -1)
                {
                    ReadOnlySpan<char> replacement = combination.Value.AsSpan();
                    ReadOnlySpan<char> found = resultSpan.Slice(occurence, combination.Key.Length);
                    ReadOnlySpan<char> prefix = resultSpan.Slice(0, occurence);
                    ReadOnlySpan<char> suffix = resultSpan.Slice(occurence + combination.Key.Length);

                    if (found.Length != replacement.Length)
                    {
                        resultSpan = stackalloc char[prefix.Length + suffix.Length + replacement.Length];
                    }
                    prefix.CopyTo(resultSpan.Slice(0, prefix.Length));
                    replacement.CopyTo(resultSpan.Slice(prefix.Length, replacement.Length));
                    suffix.CopyTo(resultSpan.Slice(prefix.Length + replacement.Length, suffix.Length));
                    occurence = resultSpan.IndexOf(combination.Key);
                }
            }

            return resultSpan.ToString();
        }

        public static string CapitalizeOld(string text)
        {
            return text[0].ToString().ToUpper() + text[1..].ToLower();
        }

        public static string Capitalize(string text)
        {
            Span<char> span = stackalloc char[text.Length];
            text.AsSpan().Slice(0, 1).ToUpper(span.Slice(0,1), null);
            text.AsSpan().Slice(1).ToLower(span.Slice(1), null);

            return span.ToString();
        }
    }
}
