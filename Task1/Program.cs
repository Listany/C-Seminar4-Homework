using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // принимает на вход 2 числа и возводит число А в натуральную степень B

            double GetExponential(double num1, double num2)
            {
                double result = Math.Pow(num1, num2);
                return result;
            }


            Console.WriteLine("Введите число А: ");
            double numA = 0; ;
            double numB = 0;
            try
            {
                 numA = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректные данные!");
            }


            Console.WriteLine("Введите число B: ");

            try
            {
                 numB = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректные данные!");
            }

            double numExponential = GetExponential(numA, numB);

            Console.WriteLine($"Число {numA}, возведенное в степень {numB} равно {numExponential}");


        }
    }
}
