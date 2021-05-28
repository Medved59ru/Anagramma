using Anagramma;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace AnagramTests
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void ReversOneWordTest()
        {
            var word = "Test1enD";

            Anagram anagram = new Anagram();

            var result = anagram.ReverseOne(word);

            Assert.AreEqual("Dnet1seT", result);
        }

        [TestMethod]
        public void ReverseSentence()
        {
            var sentence = "Test1enD For4 You";

            Anagram anagram = new Anagram();

            var result = anagram.ReverseEachWordIn(sentence);

            Assert.AreEqual(3, result.Length);
            Assert.AreEqual("Dnet1seT", result[0]);
            Assert.AreEqual("roF4", result[1]);
            Assert.AreEqual("uoY", result[2]);

        }
    }
}
