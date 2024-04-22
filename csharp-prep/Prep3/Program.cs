using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            
            while (true)
            {
                Console.Write("What is your guess? ");
                string valueFromUser = Console.ReadLine();
                int guess = int.Parse(valueFromUser);

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
            }

            Console.Write("Do you want to play again? (yes/no) ");
            string again = Console.ReadLine();
            if (again != "yes")
            {
                break;
            }

        }
        
    }
}