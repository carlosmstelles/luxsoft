using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfMultipleLibrary.Domain.Service;

namespace SumOfMultipleLibrary.Test
{
    [TestClass]
    public class SumOfMultipleTest
    {
        [DataTestMethod]
        [DataRow(10, (long)23)]
        [DataRow(100, (long)2318)]
        public void SumOfMultiple_OK(int limit, long result)
        {
            Assert.AreEqual(result, SumOfMultiple.Resolve(limit));
        }

        [DataTestMethod]
        [DataRow(-25,0)]
        [DataRow(int.MinValue, 0)]
        public void SumOfMultiple_LimitNegative(int limit, int result)
        {
            Assert.AreEqual(result, SumOfMultiple.Resolve(limit));
        }

        [DataTestMethod]
        [DataRow(0, (int)0)]
        [DataRow(1, (int)0)]
        [DataRow(2, (int)0)]
        [DataRow(3, (int)0)]
        [DataRow(5, (int)3)]
        [DataRow(15, (int)45)]
        public void SumOfMultiple_LowValue(int limit, long result)
        {
            Assert.AreEqual(result, SumOfMultiple.Resolve(limit));
        }

        [DataTestMethod]
        [DataRow(int.MaxValue / 4, (long)67253754202755344)]
        [DataRow(int.MaxValue, (long)1076060070465310994)]
        public void SumOfMultiple_HighValue(long limit, long result)
        {
            Assert.AreEqual(result, SumOfMultiple.Resolve(limit));
        }


    }
}
