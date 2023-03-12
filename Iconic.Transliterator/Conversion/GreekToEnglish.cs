using System.Text;

namespace Iconic.Transliterator.Conversion
{
    public class GreekToEnglish : ConversionInterface
    {
        /*
         * https://open.books4languages.com/greek-a1-orthography/chapter/%CE%BF%CE%B9-%CF%83%CF%85%CE%BD%CE%B4%CF%85%CE%B1%CF%83%CE%BC%CE%BF%CE%AF-%CE%B1%CF%85-%CE%B5%CF%85/
         */

        public static readonly Dictionary<string, string> Conversions = new Dictionary<string, string>()
        {
            // Those difthongs are better readable as double letters, rather than phoeneticly accurate single ones
                //{ "ai", "αι,αί" },
                //{ "i", "οι,ει,οί,εί" },
                //{ "u", "ου,ού" },

                { "ava",  "αυα,αύα"},
                { "ave",  "αυε,αύε"},
                { "avo",  "αυο,αύο,αυω,αύω"},
                { "avi",  "αυη,αύη,αυι,αύι,αυοι,αύοι,αυει,αύει"},
                { "av",  "αυβ,αύβ"},
                { "avg", "αυγ,αύγ"},
                { "avd", "αυδ,αύδ" },
                { "avz", "αυζ,αύζ"},
                { "avl", "αυλ,αύλ"},
                { "avm", "αυμ,αύμ" },
                { "avn", "αυν,αύν" },
                { "avr", "αυρ,αύρ"},

                { "eva",  "ευα,εύα"},
                { "eve",  "ευε,εύε"},
                { "evo",  "ευο,εύο,ευω,εύω"},
                { "evi",  "ευη,εύη,ευι,εύι,ευοι,εύοι,ευει,εύει"},
                { "ev", "ευβ,εύβ"},
                { "evg", "ευγ,εύγ"},
                { "evd", "ευδ,εύδ" },
                { "evz", "ευζ,εύζ"},
                { "evl", "ευλ,εύλ"},
                { "evm", "ευμ,εύμ" },
                { "evn", "ευν,εύν" },
                { "evr", "ευρ,εύρ"},

                { "afk",  "αυκ,αύκ" },
                { "afp",  "αυπ,αύπ" },
                { "aft",  "αυτ,αύτ" },
                { "afh",  "αυχ,αύχ" },
                { "af",   "αυφ,αύφ" },
                { "afth", "αυθ,αύθ" },
                { "afs",  "αυσ,αύσ" },
                { "afks", "αυξ,αύξ" },
                { "afps", "αυψ,αύψ" },

                { "efk",  "ευκ,εύκ" },
                { "efp",  "ευπ,εύπ" },
                { "eft",  "ευτ,εύτ" },
                { "efh",  "ευχ,εύχ" },
                { "ef",   "ευφ,εύφ" },
                { "efth", "ευθ,εύθ" },
                { "efs",  "ευσ,εύσ" },
                { "efks", "ευξ,εύξ" },
                { "efps", "ευψ,εύψ" },

                { "b", "μπ,β" },
                { "g", "γκ,γγ,γ" },
                { "a", "α,ά" },
                //{ "b", "β" },
                //{ "g" ,"γ" },
                { "d", "δ" },
                { "e", "ε,έ"},
                { "z", "ζ"},
                { "i", "η,ή,ι,ί,ϊ,ΐ,υ,ύ,ϋ,ΰ" },
                { "th", "θ" },
                { "k", "κ" },
                { "l", "λ" },
                { "m", "μ" },
                { "n", "ν" },
                { "ks", "ξ"},
                { "o", "ο,ό,ω,ώ" },
                { "p", "π"},
                { "r", "ρ"},
                { "s", "σ,ς"},
                { "t", "τ"},
                { "f", "φ" },
                { "kh", "χ" },
                { "ps", "ψ" }
        };

        public static string Transform(string input)
        {
            return input;
        }
    }
}
