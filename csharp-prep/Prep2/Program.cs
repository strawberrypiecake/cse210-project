using System;

class Program
{
    static void Main(string[] args)
    {
        //Prompts student to enter grade percentage and parses value into an integer variable.
        Console.WriteLine();
        Console.WriteLine("WHAT IS MY GRADE?");
        Console.WriteLine("_________________");
        Console.WriteLine();
        Console.Write("Please, provide your grade as a percentage: ");
        string gradeInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradeInput);
        string letterGrade;

        //Conditional statements that determine letter grade.
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your final grade is: {letterGrade}");
        Console.WriteLine();

        //Additional conditional statements that print message according to their ability to pass the class.
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations. You have successfully passed the class!");
        }
        else
        {
            Console.WriteLine("You have not been able to pass the class at this time. You got this, keep your head up and let's get it this time!");
        }
    }
}
