using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class Flip_Coin
    {
        Random Flip = new Random();
        double TOTAL = 35;
        double countHead = 0, countTail = 0;
        double headPercentage, tailPercentage;
        public void FlipCoin()
        {
            for (int count = 1; count <= TOTAL; count++)
            {
                double randomNumber = Flip.NextDouble();
                if (randomNumber < 0.5)
                    countHead++;
                else
                    countTail++;
            }
            Console.WriteLine("Head :" + countHead + " Tail :" + countTail);
            headPercentage = (countHead / TOTAL) * 100;
            tailPercentage = (countTail / TOTAL) * 100;
            Console.WriteLine("Percentage of Head is : " + headPercentage);
            Console.WriteLine("Percentage of Tail is :" + tailPercentage);
        }
    }
}
