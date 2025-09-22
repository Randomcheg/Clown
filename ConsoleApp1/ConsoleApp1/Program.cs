using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи натуральное число N");
            int N = int.Parse(Console.ReadLine());
            int number = 201;
            while (number % N != 0)
            {
                number++;
            }
            Console.WriteLine($"минимальное число которое делится на {N}: {number}");
            Console.ReadLine();
        }
    }
}
