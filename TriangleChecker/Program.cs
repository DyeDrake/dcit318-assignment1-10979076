using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter the length of the first side:");
        string input1 = Console.ReadLine();
        Console.WriteLine("Please enter the length of the second side:");
        string input2 = Console.ReadLine();
        Console.WriteLine("Please enter the length of the third side:");
        string input3 = Console.ReadLine();
        
        if (double.TryParse(input1, out double side1) && 
            double.TryParse(input2, out double side2) && 
            double.TryParse(input3, out double side3))
        {
           
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input, please enter valid numbers for all sides.");
        }
    }
}