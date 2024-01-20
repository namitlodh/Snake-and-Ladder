using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerpositoon = 0;
            int diceroll = Diceroll();

            Play();
            Console.ReadLine();
        }
        static void Play()
        { 
            Random rand = new Random();
            int options= rand.Next(0,3);
            switch(options)
            {
                case 0:
                    Console.WriteLine("No move");
                    break;
                case 1:
                    Console.WriteLine($"Its a Ladder, Move forward from {Position()} to {Position() + Diceroll()}");
                    break;
                case 2:
                    Console.WriteLine($"Its a Snake, Move forward from {Position()} to {Position() - Diceroll()}");
                    break;
            }
            Console.ReadLine();
        }
        static int Diceroll()
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }
        static int Position()
        {
            Random rand = new Random();
            return rand.Next(1, 101);
        }
    }
}
