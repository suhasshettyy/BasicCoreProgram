using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class PrimeFactor
    {
        public void Factorials()
        {
            Console.WriteLine("Enter the number to get factor");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n % 2 == 0)
            {
                Console.Write( ""+2);
                n /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    Console.Write( " * "+i);
                    n /= i;
                }
            }
            if (n > 2)
                Console.Write(" * " +n);
            
        }
    }
}