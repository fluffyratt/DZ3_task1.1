


using System;
using System.Text;

namespace ConsoleApp555
{
    class Program 
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            int number;
            bool isNumberValid;

            do
            {
                Console.Write("Введіть ціле число: ");
                string userInput = Console.ReadLine();

                isNumberValid = int.TryParse(userInput, out number);

                if (!isNumberValid)
                {
                    Console.WriteLine("Некоректний ввід. Спробуйте ще раз.");
                }

            } while (!isNumberValid);

            Console.WriteLine($"Ви ввели число {number}");
        }
    }
}
