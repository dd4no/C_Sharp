using System;


namespace WhileLoops
{
    class Program
    {
        static void Main()
        {
            // While Loop
            Console.WriteLine("Roll a pair of dice and enter the result");
            int roll = Convert.ToInt32(Console.ReadLine());

            while (roll != 7)
            {
                Console.WriteLine("Roll again and enter the result");
                int newRoll = Convert.ToInt32(Console.ReadLine());
                roll = newRoll;
            }
            Console.WriteLine("You won!!");
            Console.WriteLine();
            Console.WriteLine("[][][][][][][][][][][][]");
            Console.WriteLine();


            // Do-while Loop
            int differentRoll;
            do
            {
                Console.WriteLine("Roll a pair of dice and enter the result");
                int anotherRoll = Convert.ToInt32(Console.ReadLine());
                differentRoll = anotherRoll;
            }
            while (differentRoll != 7);
            Console.WriteLine("You won!!");
            Console.Read();

        }
    }
}
