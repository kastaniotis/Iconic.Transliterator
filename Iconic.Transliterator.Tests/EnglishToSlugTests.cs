using Iconic.Transliterator.Conversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iconic.Transliterator.Tests
{
    [TestClass]
    public class EnglishToSlugTests
    {
        [TestMethod]
        public void SlugTest()
        {
            var slugger = new Transliterator();
            slugger.AddConversion(new EnglishToSlug());

            var text = "New conversions can be aDded by creating a new class ";

            //lower case and spaces converted to dashes
            Assert.AreEqual("new-conversions-can-be-added-by-creating-a-new-class", slugger.Convert(text));

            //multiple spaces are joined into one
            text = "has    4 spaces";
            Assert.AreEqual(slugger.Convert(text), "has-4-spaces");

            text = " has trailing and leading spaces  that should be removed   ";
            Assert.AreEqual("has-trailing-and-leading-spaces-that-should-be-removed", slugger.Convert(text));
        }
    }
}
