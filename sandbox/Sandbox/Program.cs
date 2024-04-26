using System;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {  
        int i = 0;
        int number = 5;

        while (i < 3)
        {
            Console.Write("Guess the number from 1 to 10: ");
            int guess = int.Parse(Console.ReadLine());
            if (guess == number)
            {
                Console.WriteLine("You're right");
                break;
            }
            i++;
            Console.WriteLine("Try Again");
        }

    }
} 