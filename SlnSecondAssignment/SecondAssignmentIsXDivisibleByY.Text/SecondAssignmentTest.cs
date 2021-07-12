using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrjSecondAssignment;

namespace SecondAssignmentIsXDivisibleByY.Text
{
    [TestClass]
    public class SecondAssignmentTest
    {
        [DataTestMethod]
        [DataRow(10, 5, 1)]
        [DataRow(10, 10, 1)]
        [DataRow(100, 100, 1)]
        public void IsXDivisibleByY_OK(int x, int y, double result)
        {
            Assert.AreEqual(result, SecondAssignment.CallMod(x,y));
        }

        [DataTestMethod]
        [DataRow(0, 0, 0)]
        public void IsXDivisibleByZero(int x, int y, double result)
        {
            Assert.AreEqual(result, SecondAssignment.CallMod(x, y));
        }

        [DataTestMethod]
        [DataRow(100, -50, 1)]
        [DataRow(500, -3, 0)]
        public void IsXDivisibleByNegative(int x, int y, double result)
        {
            Assert.AreEqual(result, SecondAssignment.CallMod(x, y));
        }


        [DataTestMethod]
        [DataRow(int.MaxValue, int.MinValue, 0)]
        public void IsXDivisibleByLowValue(int x, int y, double result)
        {
            Assert.AreEqual(result, SecondAssignment.CallMod(x, y));
        }

        [DataTestMethod]
        [DataRow(int.MinValue, int.MaxValue, 0)]
        public void IsXDivisibleByHighValue(int x, int y, double result)
        {
            Assert.AreEqual(result, SecondAssignment.CallMod(x, y));
        }

    }
}
