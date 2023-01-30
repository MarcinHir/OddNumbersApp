using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbersApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdzający czy liczba jest parzysta czy nieparzysta");
            Console.WriteLine("\nPodaj liczbę całkowitą:");
            GetInput();
        }

        private static void GetInput()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Miałeś podać liczbę całkowitą!!! \n Podaj liczbę:");
                }

                else
                {
                    int moduloNumber = number % 2;

                    if (moduloNumber == 0)
                    {
                        Console.WriteLine("Twoja liczba jest parzysta.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Twoja liczba jest nieparzysta.");
                        break;
                    }
                }
            }
        }
    }
}

