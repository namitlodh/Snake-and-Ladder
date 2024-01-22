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
                int x = Diceroll();
                Console.WriteLine($"Dice gave: {x}");
                Console.ReadLine();
                Random rand = new Random();
                int options = rand.Next(0, 3);
                switch (options)
                {
                    case 0:
                        Console.WriteLine("Player found a ladder! Move forward.");
                        playposition += x;
                        int a = rand.Next(playposition, 101);
                        Console.WriteLine($"Player moved from {playposition} to {a}");
                        playposition = a;
                        break;
                    case 1:
                        Console.WriteLine("Its a Snake, Move backward");
                        playposition+=x;
                        int b = rand.Next(2,playposition);
                        Console.WriteLine($"Player moved from {playposition} to {b}.");
                        playposition = b;
                        break;
                    case 2:
                        int previous = playposition;
                        playposition += x;
                        Console.WriteLine($"Player moved from {previous} to {playposition}.");
                        break;
                }


                if (playposition < 0)
                {
                    playposition = 0;
                }
                else if (playposition == 100)
                {
                    Console.WriteLine("Total die count " + count);
                    Console.WriteLine("Player reached the winning position (100)!");
                }
                else if (playposition > 100)
                {
                    Console.WriteLine($"Player is in the same position {playposition-Diceroll()}!");
                }
            Console.ReadLine();
            }
        }

        static int Diceroll()
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }
    }  
}

 