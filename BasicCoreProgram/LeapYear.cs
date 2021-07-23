using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class LeapYear
    {
        int year;
        bool check;
        public void LeapYearCheck()
        {
            Console.WriteLine("Enter a year ");
            year = Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                check = true;
            else
                check = false;
            if (check)
                Console.WriteLine("Entered year " + year + " is Leap year");
            else
                Console.WriteLine("Entered year " + year + " is not a Leap year");
        }
    }
}