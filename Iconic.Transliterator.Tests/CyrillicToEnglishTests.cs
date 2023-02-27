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
            transliterator.AddConversion(new CyrillicToEnglish());

            var text = "Примерен текст";
            Assert.AreEqual("Primeren tekst", transliterator.Convert(text));

            transliterator.AddConversion(new EnglishToSlug());
            Assert.AreEqual("primeren-tekst", transliterator.Convert(text));
        }
    }
}
