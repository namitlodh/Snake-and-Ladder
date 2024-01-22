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
            int playposition = 0;
            int count = 0;
            while (playposition < 100)
            {
                Console.WriteLine($"Dice count: {count++}");
                Console.WriteLine($"Player is currently at position {playposition}. Press Enter to simulate a player's turn.");
                Console.ReadLine();
                Random rand = new Random();
                int options = rand.Next(0, 3);
                switch (options)
                {
                    case 0:
                        Console.WriteLine("Its a Ladder, Move forward");
                        playposition += Diceroll();
                        Console.WriteLine($"Player moved from {playposition - Diceroll()} to {playposition}");
                        break;
                    case 1:
                        Console.WriteLine("Its a Snake, Move backward");
                        int previousPosition = playposition;
                        playposition -= Diceroll();
                        Console.WriteLine($"Player moved from {previousPosition} to {playposition}.");
                        break;
                    case 2:
                        Console.WriteLine("No move");
                        break;
                }


                if (playposition < 0)
                {
                    playposition = 0;
                }
                else if (playposition == 100)
                {
                    Console.WriteLine("Player reached the winning position (100)!");
                }
                else if (playposition > 100)
                {
                    Console.WriteLine($"Player is in the same position {playposition-Diceroll()}!");
                }
            }
        }
        static int Diceroll()
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }
    }  
}

 