using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class VowelConsonant
    {
        char alphabet;
        public void Check()
        {
            Console.WriteLine("Enter a Character");
            alphabet = Char.ToLower(Convert.ToChar(Console.ReadLine()));
            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
                Console.WriteLine(alphabet + " is vowel");
            else
                Console.WriteLine(alphabet + " is consonant");

        }
    }
}