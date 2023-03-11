using Iconic.Transliterator.Conversion;

namespace Iconic.Transliterator.Tests
{
    [TestClass]
    public class GermanToEnglishTests
    {
        [TestMethod]
        public void GermanTests()
        {
            var transliterator = new Transliterator();
            transliterator.AddConversion(new GermanToEnglish());

            //Simple text is converted to greeklish. Capitalization is maintained.
            var text = "Prüfung auf deutsch";
            Assert.AreEqual("Pruefung auf deutsch", transliterator.Convert(text));

            //Duals are shown properly
            text = "Prüfung bässe andrä";
            Assert.AreEqual("Pruefung baesse andrae", transliterator.Convert(text));
        }
    }
}
