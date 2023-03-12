namespace Iconic.Transliterator.Tests
{
    [TestClass]
    public class TransliteratorTests
    {
        [TestMethod]
        public void CapitalizationTest()
        {
            var lowercase = "δοκιμή";
            Assert.AreEqual("Δοκιμή", Transliterator.CapitalizeOld(lowercase));
            Assert.AreEqual("Δοκιμή", Transliterator.Capitalize(lowercase));
        }        
    }
}