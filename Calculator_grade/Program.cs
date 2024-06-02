
using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kindly enter your grade within the range of 0 to 100.: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int grade))
        {
            if (grade >=0 && grade <= 100)
            {
                string GradeInLetter = grade switch
                {
                    >= 90 => "A",
                    >= 80 => "B",
                    >= 70 => "C",
                    >= 60 => "D",
                    _ => "F"
                };
                Console.WriteLine("Your grade is " + GradeInLetter);
            }
            else
            {
                Console.WriteLine("Invalid input, out of range 0 - 100");
            }
        }
        else
        {
            Console.WriteLine("Invalid input, Type in a valid numerical grade.");
        }

    }
}