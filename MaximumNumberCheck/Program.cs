using System;

namespace MaximumNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Maximum number check program.");
            //Console.WriteLine("Find max Number");
            //MaxNumberCheck MaxNum = new MaxNumberCheck();
            //int output = MaxNum.MaximumIntegerNumber(11,22,33);
            //Console.WriteLine(output);
            //float floatoutput = MaxNum.MaximumFloatNumber(111.2f, 22.45f, 78.56f);
            //Console.WriteLine(floatoutput);
            //string stringoutput = MaxNum.MaximumStringNumber("22", "33", "44");
            //Console.WriteLine(stringoutput);
            int[] intArray = { 112, 344, 432, 555, 678 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "111", "222", "333", "55", "999" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();
            Console.ReadKey();
        }
    }
}
