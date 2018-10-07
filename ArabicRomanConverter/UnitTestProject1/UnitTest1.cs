using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArabicRomanConverter;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConvertTest()
        {
            int expected = 0;
            var actual = ConvertRomanToArabic.Convert("");
            Assert.AreEqual(expected,actual);
        }
    }
}
