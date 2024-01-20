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
            Console.WriteLine(diceroll);
            Console.ReadLine();
        }
        static int Diceroll()
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }
    }
}
