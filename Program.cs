/*Дано целое число N большее 0, найти число, получен-
ное при прочтении числа N справа налево. Например,
если было введено число 345, то программа должна
вывести число 543.*/
using System;

namespace HomeCaseCS_Lesson1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N <= 0)
            {
                Console.WriteLine("Error! Enter positive numbers " +
                    "greater than 0");
            }
            else
            {
                while (N > 0)
                {
                    Console.Write(N % 10);
                    N /= 10;
                }
            }

            Console.ReadKey();
        }
    }
}