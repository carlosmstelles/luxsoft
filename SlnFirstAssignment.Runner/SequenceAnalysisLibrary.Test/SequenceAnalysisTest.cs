using Microsoft.VisualStudio.TestTools.UnitTesting;
using SequenceAnalysisLibrary.Domain.Service;


namespace SequenceAnalysisLibrary.Test
{
    [TestClass]
    public class SequenceAnalysisTest
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow("This IS a STRING", "GIINRSSTT")]
        public void SequenceAnalysisUpperString_OK(string text, string result)
        {
            Assert.AreEqual(result, SequenceAnalysis.UpperString(text));
        }

        [DataTestMethod]
        [DataRow("HI, WoUld you lIke to Travel to PeteR's houSe neXt weekEnd ? It's goiNg tO bE a SunNy weeKend.", "EEHIIIKNNOPRSSTUWX")]
        public void SequenceAnalysisUpperString_WithSpecialChar(string text, string result)
        {
            Assert.AreEqual(result, SequenceAnalysis.UpperString(text));
        }
    }
}
