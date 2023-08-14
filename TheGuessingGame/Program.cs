using System;

namespace TheGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome \nEnter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age > 18)
            {
                Console.WriteLine("You're allowed to play this game");
                Console.WriteLine();
                Console.WriteLine("Press 1 to play numbers guessing game or\nPress 2 to play colour guessing game.");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("\nLet's begin...\nYou have 3 attempts to guess the number I'm thinking of.\nEnter number:");
                    Random random = new Random();
                    int rand = random.Next(1, 15);
                    int count = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        count++;
                        int guess = Convert.ToInt32(Console.ReadLine());
                        if (guess < rand)
                        {
                            Console.WriteLine("Number guessed is low.");
                        }
                        else if (guess > rand)
                        {
                            Console.WriteLine("Number guessed is high");
                        }
                        else
                            Console.WriteLine("Congratulations!! You guessed right in {0} attempts", count);

                    }
                    Console.WriteLine("\nThe number I was thinking of was {0}", rand);



                }else if(input == 2) 
                {
                    Console.WriteLine("\nLet's begin...\nYou have 3 attempts to guess the colour I'm thinking of.\nEnter colour:");
                    Random random = new Random();
                  
                    
                }


            }
            else
            Console.WriteLine("You're not eligible to play this game.");
        }
    }
}
