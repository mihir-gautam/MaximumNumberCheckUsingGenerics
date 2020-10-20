using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumNumberCheck;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(9,4,1)]
        [DataRow(43,32,11)]
        public void Given_Max_Number_At_First_Position_Return_Max(int num1, int num2, int num3)
        {
            MaxNumberCheck MaxInt = new MaxNumberCheck();
            int result = MaxInt.MaximumIntegerNumber(num1,num2,num3);
            int expected = num1;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(9, 23, 1)]
        [DataRow(43, 65, 11)]
        public void Given_Max_Number_At_Second_Position_Return_Max(int num1, int num2, int num3)
        {
            MaxNumberCheck MaxInt = new MaxNumberCheck();
            int result = MaxInt.MaximumIntegerNumber(num1, num2, num3);
            int expected = num2;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [DataRow(9, 4, 43)]
        [DataRow(43, 32, 85)]
        public void Given_Max_Number_At_Third_Position_Return_Max(int num1, int num2, int num3)
        {
            MaxNumberCheck MaxInt = new MaxNumberCheck();
            int result = MaxInt.MaximumIntegerNumber(num1, num2, num3);
            int expected = num3;
            Assert.AreEqual(expected, result);
        }
    }
}
