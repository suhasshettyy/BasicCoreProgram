using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class Power
    {
        int number;
        double x;
        public void PowerofTwo()
        {
            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            for (int count = 0; count <= number; count++)
            {
                x = Math.Pow(2, count);
                Console.WriteLine(" 2^" + count + "  is: " + x);
            }
        }
    }
}