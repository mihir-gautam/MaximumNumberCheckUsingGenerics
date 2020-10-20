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
        public void Given_Int_Max_Number_At_First_Position_Return_Max(int num1, int num2, int num3)
        {
            MaxNumberCheck MaxInt = new MaxNumberCheck();
            int result = MaxInt.MaximumIntegerNumber(num1,num2,num3);
            int expected = num1;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(9, 23, 1)]
        [DataRow(43, 65, 11)]
        public void Given_Int_Max_Number_At_Second_Position_Return_Max(int num1, int num2, int num3)
        {
            MaxNumberCheck MaxInt = new MaxNumberCheck();
            int result = MaxInt.MaximumIntegerNumber(num1, num2, num3);
            int expected = num2;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [DataRow(9, 4, 43)]
        [DataRow(43, 32, 85)]
        public void Given_Int_Max_Number_At_Third_Position_Return_Max(int num1, int num2, int num3)
        {
            MaxNumberCheck MaxInt = new MaxNumberCheck();
            int result = MaxInt.MaximumIntegerNumber(num1, num2, num3);
            int expected = num3;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [DataRow(9.4f, 4.2f, 1.6f)]
        [DataRow(43.6f, 32.1f, 11.4f)]
        public void Given_Float_Max_Number_At_First_Position_Return_Max(float num1, float num2, float num3)
        {
            MaxNumberCheck MaxFloat = new MaxNumberCheck();
            float result = MaxFloat.MaximumFloatNumber(num1, num2, num3);
            float expected = num1;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(9.1f, 23.5f, 1.4f)]
        [DataRow(43.6f, 65.1f, 11.4f)]
        public void Given_Float_Max_Number_At_Second_Position_Return_Max(float num1, float num2, float num3)
        {
            MaxNumberCheck MaxFloat = new MaxNumberCheck();
            float result = MaxFloat.MaximumFloatNumber(num1, num2, num3);
            float expected = num2;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [DataRow(9.6f, 4.3f, 43.6f)]
        [DataRow(43.1f, 32.3f, 85.9f)]
        public void Given_Float_Max_Number_At_Third_Position_Return_Max(float num1, float num2, float num3)
        {
            MaxNumberCheck MaxFloat = new MaxNumberCheck();
            float result = MaxFloat.MaximumFloatNumber(num1, num2, num3);
            float expected = num3;
            Assert.AreEqual(expected, result);
        }
    }
}
