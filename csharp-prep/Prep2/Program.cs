using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade percentage: ");
        string valueFromUser = Console.ReadLine();

        int grade = int.Parse(valueFromUser);
        string letterGrade = null;

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade =  "B";
        }
        else if (grade  >= 70)
        {
            letterGrade =  "C";
        }
        else if (grade  >= 60)
        {
            letterGrade =  "D";
        }
        else
        {
            letterGrade =  "F";
        }

        Console.WriteLine($"Your grade is: {letterGrade}");

        if (grade >= 70)
        {
            Console.WriteLine($"Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine($"You failed, try again next semester.");
        }
    }
}