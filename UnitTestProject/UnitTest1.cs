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
        [TestMethod]
        [DataRow("Peach","Banana","Apple")]
        [DataRow("Pumpkin","Amla", "Burger")]
        public void Given_Strings_Max_At_First_Position_Return_Max(string str1, string str2, string str3)
        {
            MaxNumberCheck MaxString = new MaxNumberCheck();
            string result = MaxString.MaximumStringNumber(str1, str2, str3);
            string expected = str1;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("Burger","Pumpkin", "Amla")]
        [DataRow("Banana", "Peach", "Burger")]
        public void Given_Strings_Max_At_Second_Position_Return_Max(string str1, string str2, string str3)
        {
            MaxNumberCheck MaxString = new MaxNumberCheck();
            string result = MaxString.MaximumStringNumber(str1, str2, str3);
            string expected = str2;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [DataRow("Apple","Banana", "Peach")]
        [DataRow("Amla", "Burger", "Pumpkin")]
        public void Given_Strings_Max_At_Third_Position_Return_Max(string str1, string str2, string str3)
        {
            MaxNumberCheck MaxString = new MaxNumberCheck();
            string result = MaxString.MaximumStringNumber(str1, str2, str3);
            string expected = str3;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Given_StringArray_Check_With_Generic_Return_MaxValue()
        {
            string expected = "Peach";
            GenericMaximum<string> generic = new GenericMaximum<string>(new string[4] { "Apple", "Banana", "Guava", "Peach" });
            string actual = generic.MaxMethod();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Given_IntegerArray_Check_With_Generic_Return_MaxValue()
        {
            int expected = 99;
            GenericMaximum<int> generic = new GenericMaximum<int>(new int[5] { 24, 45, 65, 86, 99 });
            int actual = generic.MaxMethod();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Given_FloatArray_Check_With_Generic_Return_MaxValue()
        {
            GenericMaximum<float> generic = new GenericMaximum<float>(new float[3] { 10.5f, 16.4f, 88.9f });
            float expected = 88.9f;
            float actual = generic.MaxMethod();
            Assert.AreEqual(expected, actual);
        }

    }
}
