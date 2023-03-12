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
            transliterator.AddConversions(new CyrillicToEnglish());

            var text = "Примерен текст";
            Assert.AreEqual("Primеrеn tеkst", transliterator.Convert(text));

            transliterator.AddConversions(new EnglishToSlug());
            
            Assert.AreEqual("primеrеn-tеkst", transliterator.Convert(text));
        }
    }
}
