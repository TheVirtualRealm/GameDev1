using System;

namespace NerdLab123
{
    class Program
    {
        static void Main(string[] args)
        {

            Player();

            Console.ReadKey();
        }

        static public void Player()
        {

            Console.WriteLine("Enter your name: ");
            string playerName = Console.ReadLine();

            Console.WriteLine($"Hello {playerName}");

            Console.WriteLine("Enter your age: ");
            int playerAge = Convert.ToInt32(Console.ReadLine());
            if (playerAge >= 25)
            {
                Console.WriteLine($"{playerAge}....? WOW!! you're old.... Welcome I guess");
            }
            else
            {
                Console.WriteLine("Welcome young traveler");
            }

            Random luckGen = new Random();
            decimal luck = luckGen.Next(1, 2);

            Random rollMethod = new Random();
            decimal roll = rollMethod.Next(1, 10);

            decimal luck1 = (roll * luck);

            Console.WriteLine($"Your luck is {luck1}");

        }


    }
}
