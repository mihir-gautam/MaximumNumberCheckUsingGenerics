﻿using System;

namespace MaximumNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum number check program.");
            Console.WriteLine("Find max Number");
            MaxNumberCheck MaxInt = new MaxNumberCheck();
            int output = MaxInt.MaximumIntegerNumber(11,22,33);
            Console.WriteLine(output);
            float floatoutput = MaxInt.MaximumFloatNumber(111.2f, 22.45f, 78.56f);
            Console.WriteLine(floatoutput);
        }
    }
}
