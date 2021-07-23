using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class QuotientAndRemainder
    {
        int quotient, remainder;
        public void MathOperation()
        {
            Console.WriteLine("Enter a value of divident");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value of divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            quotient = divident / divisor;
            remainder = divident % divisor;
            Console.WriteLine("Quotient : " + quotient);
            Console.WriteLine("Remainder : " + remainder);
        }
    }
}