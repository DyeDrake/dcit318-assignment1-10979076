// See https://aka.ms/new-console-template for more information
using System;

class TheaterTicket
{
    static void Main(string[] args)
    {
        Console.WriteLine("How old are you? ");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            int ticketPrice = age switch
            {
                <= 12 => 7,
                >= 65 => 7,
                _ => 10
            };
            Console.WriteLine("Your ticket price is " +"GHS"+ ticketPrice);
        }
        else
        {
            Console.WriteLine("Invalid input, try again.");
        }
    }
}