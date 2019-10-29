using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestWebGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для определения четности");
            int number = Convert.ToInt32(Console.ReadLine());
            ChetnostiNumber(number);
        }
        static void ChetnostiNumber(int a)
        {
        if (a%2==0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }
        }
    }
}
