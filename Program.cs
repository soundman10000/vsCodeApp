using System;
using Application.N.Shit;
using static System.Console;
namespace vsCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var jason = new Person("Jason", "Malley", new DateTime(1982, 11, 10));

            Console.WriteLine($"Welcome, {jason.FirstName}");
            Console.WriteLine($"Our records indicate that you were born on {jason.Birthdate.ToShortDateString()}");

            var theCorrectAnswer = false;
            while (!theCorrectAnswer)
            {
                Console.WriteLine("Is this correct.");
                var entry = Console.ReadLine();
                switch (entry.ToUpper())
                {
                    case "YES":
                        theCorrectAnswer = true;
                        break;
                    case "EXIT":
                        return;
                }

                WriteLine("why don't you try again.");
            }

            WriteLine("That's more like it");

            Console.Clear();
            WriteLine("What would you like to do today?");
            var input = Console.ReadLine();
            var processedInput = ActivityCalculator.AnalyzeEntry(input);
            WriteLine(processedInput);

        }
    }
}