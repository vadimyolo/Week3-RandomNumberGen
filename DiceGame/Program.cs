using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus on kaks mängijat
            //mõlemad mängijad viskavad täringut
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija kes viskas rohkem ongi võitja.
            //programm kuulutab võitjat.

            Random rnd = new Random();
            int myRandomNumber = rnd.Next(1, 7);//nr 1 - 6

            string PlayerOne = "Ludwig";
            string PlayerTwo = "LudwigBot";

            int Ludwig = rnd.Next(1, 7);
            int LudwigBot = rnd.Next(1, 7);

            Console.WriteLine($"{PlayerOne} veeretas {Ludwig}");
            Console.WriteLine($"{PlayerTwo} veeretas {LudwigBot}");
            if (Ludwig < LudwigBot)
            {
                Console.WriteLine($"{PlayerTwo} võitis numbriga {myRandomNumber}");
            }
            else if (Ludwig > LudwigBot)
            {
                Console.WriteLine($"{PlayerOne} võitis numbriga {myRandomNumber}.");
            }
            else
            {
                Console.WriteLine($"Jäite viiki numbriga");
            }
        }
    }
}
