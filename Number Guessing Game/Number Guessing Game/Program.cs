using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input;
            int guess, low = 0, high = 100;
            //Random random = new Random();
            //int randomnumber = random.Next(0, 100);



            while (true)
            {
                guess = (high + low) / 2;
                Console.WriteLine("Is your number {0}?", guess);
                Console.WriteLine("Higher? Lower? Correct?");
                Input = Console.ReadLine();

                if (Input == "Lower" || Input == "L" || Input == "l" || Input == "lower")
                {
                    high = guess - 1;
                    //Console.WriteLine("{0}", randomnumber);
                }

                if (Input == "Higher" || Input == "H" || Input == "h" || Input == "higher")
                {
                    low = guess + 1;
                    //Console.WriteLine("{0}", randomnumber);
                }

                if (Input == "Correct" || Input == "C" || Input == "c" || Input == "correct")
                {
                    Console.WriteLine("Yay I won!");
                    break;
                }
            }
        }
    }
}



