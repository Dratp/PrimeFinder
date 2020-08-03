using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = false;
            int input = 0;
            Console.WriteLine("Let's locate some primes!\n");
            Console.WriteLine("This program will find you any prime, in order, from first prime number on.\n");
            while (!cont)
            {
                input = GetInteger("Which prime number are you looking for? ");
                PrimeFinder AlphaTrion = new PrimeFinder();
                int prime = AlphaTrion.GetPrime(input);
                Console.WriteLine($"\nThe number {input} prime is {prime}.");
                cont = CarryOn();
            }

        }

        static int GetInteger(string quest)
        {
            bool isValid = true;
            string input;
            int number;

            while (true)
            {
                Console.Write(quest);
                input = Console.ReadLine();
                isValid = int.TryParse(input, out number);
                if (!isValid)
                {
                    Console.WriteLine("Please enter a whole number");
                }
                else if (number < 1)
                {
                    Console.WriteLine("Please enter a number larger than 1");
                }
                else
                {
                    return number;
                }
            }
        }

        static bool CarryOn()
        {
            string input = "";
            while (true)
            {
                Console.Write("Do you want to find another prime number? (y/n): ");
                input = Console.ReadLine().ToLower();
                if (input == "n" || input == "no")
                {
                    return true;
                }
                else if(input == "y" || input == "yes")
                {
                    return false;
                }
            }
            
        }
    }
}
