using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class EvenOdd
    {
        int number;
        public void CheckNumber()
        {
            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine(number + " is even number");
            else
                Console.WriteLine(number + " is odd number");

        }
    }
}