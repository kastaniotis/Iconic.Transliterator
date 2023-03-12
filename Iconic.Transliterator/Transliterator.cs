using Iconic.Transliterator.Conversion;
using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Schema;

namespace Iconic.Transliterator
{
    public class Transliterator
    {
        private Dictionary<string, string> Conversions = new Dictionary<string, string>();
        private List<Type> Types = new();
        public void AddConversions(Type className) 
        {
            var conversions = className.GetField("Conversions");//.GetProperty("Conversions");
            Dictionary<string, string> conversion = new();// (Dictionary<string,string>).GetConstantValue();
            conversion = conversions.GetValue(conversions) as Dictionary<string, string>;

            Types.Add(className);
            foreach (var item in conversion) 
            {
                foreach (var current in item.Value.Split(","))
                {
                    Conversions.Add(current, item.Key);
                    var s = current.ToUpper();
                    Conversions.TryAdd(current.ToUpper(), item.Key.ToUpper());
                    Conversions.TryAdd(Capitalize(current), Capitalize(item.Key));
                }
            }
            Conversions.OrderByDescending(i => i.Key.Length);
        }
        public string Convert(string text)
        {
            // Elliminate multiple spaces
            while(text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }

            foreach (var action in Types)
            {
                text = action.GetMethod("Transform").Invoke(action, new object[] { text }).ToString();
            }

            var builder = new StringBuilder(text);
            
            foreach (var combination in Conversions)
            {
                builder.Replace(combination.Key, combination.Value);
            }

            return builder.ToString();
        }

        public string ConvertSpan(string text)
        {
            Span<char> resultSpan = stackalloc char[text.Length];
            text.AsSpan().CopyTo(resultSpan);
            int occurence = -1;
            
            foreach (var combination in Conversions)
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

        public static string Capitalize(string text)
        {
            return text[0].ToString().ToUpper() + text[1..].ToLower();
        }
    }
}
