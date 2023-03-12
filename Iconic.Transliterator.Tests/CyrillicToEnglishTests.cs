using Iconic.Transliterator.Conversion;

namespace Iconic.Transliterator.Tests
{
    [TestClass]
    public class CyrillicToEnglishTests
    {
        [TestMethod]
        public void CyrillicTest()
        {
            var transliterator = new Transliterator();
            transliterator.AddConversions(typeof(CyrillicToEnglish));

            var text = "Примерен текст";
            var result = transliterator.Convert(text);
            var t = result.CompareTo("Primeren tekst");
            Assert.AreEqual("Primеrеn tеkst", result);

            transliterator.AddConversions(typeof(EnglishToSlug));
            Assert.AreEqual("primеrеn-tеkst", transliterator.Convert(text));
        }
    }
}
