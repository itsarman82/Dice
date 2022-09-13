using System;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Dice this program make 2 random dice resaults.");

            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);

            Console.WriteLine(dice1);
            Console.WriteLine(dice2);
        }
    }
}
