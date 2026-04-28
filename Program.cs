using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_ConsoleApp_Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Asking the user their name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name + "!");

            //2. Asking the user for their balance and withdrawal amount
            double balance = GetAmount("Enter your balance: ");
            double withdraw = GetAmount("Enter withdrawal amount: ");

            //3. Output
            if (withdraw <= balance)
            {
                balance -= withdraw;
                Console.WriteLine("\nTransaction successful!");
                Console.WriteLine("New balance: " + balance);
                Console.WriteLine("Time: " + DateTime.Now);
            }
            else
            {
                Console.WriteLine("\nInsufficient funds.");
            }
        }

        static double GetAmount(string message)
        {
            double amount;
            Console.Write(message);

            while (!double.TryParse(Console.ReadLine(), out amount))
            {
                Console.Write("Invalid input. Enter a number: ");
            }

            return amount;
        }
    }
}
