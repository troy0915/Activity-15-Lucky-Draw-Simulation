using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_15_Lucky_Draw_Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] winningNumbers = { 7, 14, 21, 28, 35, 42, 56, 63, 77, 88 };
            int[] userNumbers = new int[20];

            Console.WriteLine("Welcome to the Lucky Number Game!");
            Console.WriteLine("Please enter your lucky numbers (1-99).");

            for (int i = 0; i < 20; i++)
            {
                bool isValid = false;
                while (!isValid)
                {
                    Console.Write($"User  {i + 1}, enter your lucky number (1-99): ");
                    if (int.TryParse(Console.ReadLine(), out userNumbers[i]))
                    {
                        if (userNumbers[i] >= 1 && userNumbers[i] <= 99)
                        {
                            isValid = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid number! Please enter a number between 1 and 99.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                    }
                }
            }

            Console.WriteLine("\nResults:");
            for (int i = 0; i < 20; i++)
            {
                if (Array.Exists(winningNumbers, number => number == userNumbers[i]))
                {
                    Console.WriteLine($"CONGRATULATIONS User {i + 1}! Your lucky number {userNumbers[i]} is a winning number!");
                }
            }

            Console.WriteLine("\nThank you for playing the Lucky Number Game!");

        }
    }
}
