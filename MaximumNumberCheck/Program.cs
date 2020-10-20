using System;

namespace MaximumNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum number check program.");
            Console.WriteLine("Find max Number");
            int output = MaxNumberCheck.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
        }
    }
}
