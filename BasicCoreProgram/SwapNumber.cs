using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class SwapNumber
    {
        int temp;
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        static SwapNumber()
        {
            Console.WriteLine("Enter the First Number and Second Number");
        }
        public void Swap()
        {
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine("First number after swap:" + firstNumber);
            Console.WriteLine("Second number after swap:" + secondNumber);
        }
    }
}
