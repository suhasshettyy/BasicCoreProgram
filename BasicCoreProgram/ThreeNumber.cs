using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class ThreeNumber
    {
        int number1 = 65, number2 = 98, number3 = 77;
        public void CheckLargest()
        {
            if (number1 > number2 && number1 > number3)
                Console.WriteLine(number1 + " is largest");
            if (number2 > number1 && number2 > number3)
                Console.WriteLine(number2 + " is largest");
            if (number3 > number1 && number3 > number2)
                Console.WriteLine(number3 + " is largest");
        }
    }

}