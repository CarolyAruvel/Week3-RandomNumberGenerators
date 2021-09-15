using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat
            //mõlemad mängijad viskavad täringut
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskas ongi võitja
            //programm kuulutab võitja

            Random rnd = new Random();

            string PlayerOne = "Mirjam";
            string PlayerTwo = "Caroly";

            int MirjamThrow = rnd.Next(1, 10);
            int CarolyThrow = rnd.Next(1, 10);

            Console.WriteLine($" {PlayerOne} threw {MirjamThrow};");
            Console.WriteLine($" {PlayerTwo} threw {CarolyThrow};");

            if (MirjamThrow > CarolyThrow)
            {
                Console.WriteLine($"{PlayerOne} wins");
            }
            else if (MirjamThrow < CarolyThrow)
            {
                Console.WriteLine($"{PlayerTwo} wins");
            }
            else
            {
                Console.WriteLine("Draw. Let them try again!");
            }
        }
    }
}
