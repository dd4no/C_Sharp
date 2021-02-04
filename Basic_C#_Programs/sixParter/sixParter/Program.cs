using System;
using System.Collections.Generic;


namespace sixParter
{
    class Program
    {
        static void Main()
        {
            // Part 1
            // String array iteration

            string[] text = { "Some text plus ", "Some more text plus ", "And even more text plus " };
            
            Console.WriteLine("Please enter some text:");
            string userText = (Console.ReadLine());

            for (int i = 0; i < text.Length; i++) 
            {
                text[i] += userText;
            }
            
            for (int j = 0; j < text.Length; j++)
            {
                Console.WriteLine(text[j]);
                
            }
            Console.WriteLine();

            // Part 2
            // Infinite Loops

            //int x = 0;
            //while (x == 0)
            //{
            //    Console.WriteLine("It just goes on and on and on...");
            //}

            //Corrected Loop
            int x = 0;
            while (x == 0)
            {
                Console.WriteLine("Only once");
                x++;
            }
            Console.WriteLine();

            // Part 3
            // Loops with conditions "less than" and "less than or equal to"

            for (int y = 0; y < 5; y++)
            {
                Console.WriteLine(y);
            }
            Console.WriteLine();

            for (int z = 0; z <= 3; z++)
            {
                Console.WriteLine("Loop number" + (z + 1));
            }
            Console.WriteLine();

            // Part 4
            // Searching lists

            List<string> letters = new List<string> { "A", "B", "C", "D", "E", "F" };

            Console.WriteLine("Choose a letter:");
            string userLetter = (Console.ReadLine());
            userLetter = userLetter.ToUpper();

            if (letters.Contains(userLetter))
            {
                for (int a = 0; a < letters.Count; a++)
                {
                    if (userLetter == letters[a])
                    {
                        Console.WriteLine("Your letter was found at index: " + a);
                        Console.WriteLine();
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Sorry. That letter is not on the list.");
                Console.WriteLine();
            }

            // Part 5
            // Lists containing identical strings

            List<string> names = new List<string> { "BILL", "BOB", "JIM", "BOB", "DAVE", "BOB", "BILL", "BILL", "BOB", "DAVE", "JIM" };
            List<int> indices = new List<int>();

            Console.WriteLine("Please choose one of these names:");
            Console.WriteLine(" Bill, Bob, Jim, or Dave");
            string userChoice = (Console.ReadLine());
            userChoice = userChoice.ToUpper();

            if (names.Contains(userChoice))
            {
                for (int b = 0; b < names.Count; b++)
                {
                    if (userChoice == names[b])
                    {
                        indices.Add(b);
                    }
                }

                Console.WriteLine("That name is found at indices: ");
                foreach (int index in indices)
                {
                    Console.Write(index.ToString() + ", ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Sorry. That name is not on the list");
                Console.WriteLine();
            }

            // Part 6
            // Determine if element is already in list

            Console.WriteLine();
            List<string> cheapBeers = new List<string> { "Miller", "Busch", "Rolling Rock", "Keystone", "Miller", "Meisterbrau", "Old Milwaukee", "Busch" };
            List<string> onList = new List<string>();

            foreach (string beer in cheapBeers)
            {
                if (onList.Contains(beer))
                {
                    Console.WriteLine(beer + " is already on the list");
                }
                else
                {
                    Console.WriteLine(beer + " is new to the list");
                    onList.Add(beer);
                }
            }

            Console.ReadLine();
        }
    }
}
