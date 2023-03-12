using Iconic.Transliterator.Conversion;

namespace Iconic.Transliterator.Tests
{
    [TestClass]
    public class GreekToEnglishTests
    {
        [TestMethod]
        public void GreekTests()
        {
            var transliterator = new Transliterator();
            transliterator.AddConversions(new GreekToEnglish());
            //transliterator.AddConversions(EnglishToSlug.Conversions);

            //Simple text is converted to greeklish. Capitalization is maintained.
            var text = "Δοκιμή στα Ελληνικά";
            Assert.AreEqual("Dokimi sta Ellinika", transliterator.Convert(text));

            //Combinations are maintained
            text = "Ευκαρπία Εύη Αιώνας οιωνός Ευθυμία";
            Assert.AreEqual("Efkarpia Evi Aionas oionos Efthimia", transliterator.Convert(text));
        }
    }
}
