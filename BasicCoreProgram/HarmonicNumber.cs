using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class HarmonicNumber
    {
        public void HarmonicSeries()
        {
            int i, number;
            double s = 0;
            Console.Write("Input the number of terms : ");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                Console.Write("+ 1/{0} ", i);
                s += 1 / (float)i;
            }
            Console.WriteLine("Sum of Series is : " + s);
        }
    }
}