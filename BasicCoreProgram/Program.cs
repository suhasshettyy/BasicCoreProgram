using System;

namespace BasicCoreProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            int choice;
            //Constants
            const int FLIP_COIN = 1, LEAP_YEAR = 2, POWER = 3, HARMONIC_NUMBER = 4,  QUOTIENT_AND_REMAINDER = 5, SWAP_NUMBER = 6, EVEN_ODD = 7, VOWEL_CONSONANT = 8, THREE_NUMBER = 9, FACTOR = 10;
            Console.WriteLine("Press 1 : Flip Coin Program");
            Console.WriteLine("Press 2 : Leap Year Program");
            Console.WriteLine("Press 3 : Power Program");
            Console.WriteLine("Press 4 : Harmonic Number Program");
            Console.WriteLine("Press 5 : Quotient and Remainder Program");
            Console.WriteLine("Press 6 : Swap Number Program");
            Console.WriteLine("Press 7 : Even Odd Program");
            Console.WriteLine("Press 8 : Vowel Consonant Program");
            Console.WriteLine("Press 9 : Largest between Three Number Program");
            Console.WriteLine("Press 10 : Prime Factor Program");
            Console.WriteLine("Enter your choice");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case FLIP_COIN:
                    Flipcoin flip_coin = new Flipcoin();
                    flip_coin.FlipCoin();
                    break;
                case LEAP_YEAR:
                    LeapYear leapyear = new LeapYear();
                    leapyear.LeapYearCheck();
                    break;
                case POWER:
                    Power power = new Power();
                    power.PowerofTwo();
                    break;
                case HARMONIC_NUMBER:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.HarmonicSeries();
                    break;
                case QUOTIENT_AND_REMAINDER:
                    QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
                    quotientAndRemainder.MathOperation();
                    break;
                case SWAP_NUMBER:
                    SwapNumber swapNumber = new SwapNumber();
                    swapNumber.Swap();
                    break;
                case EVEN_ODD:
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.CheckNumber();
                    break;
                case VOWEL_CONSONANT:
                    VowelConsonant vowelConsonant = new VowelConsonant();
                    vowelConsonant.Check();
                    break;
                case THREE_NUMBER:
                    ThreeNumber threeNumber = new ThreeNumber();
                    threeNumber.CheckLargest();
                    break;
                case FACTOR:
                    PrimeFactor primefactor = new PrimeFactor();
                    primefactor.Factorials();
                    break;
                default:
                    Console.WriteLine("Enter a right choice");
                    break;
            }
        }
    }
}
