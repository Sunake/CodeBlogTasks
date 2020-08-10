using System;
using System.Linq;

namespace CodeBlogTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task10(new int[] { 9, 3, 5, 7, 1 });
        }

        static void Task2(int a, int b)
        {
            //Даны натуральные числа a и b. Вычислите произведение a * b, используя в программе только операции +, -, ==, !=, =
            int c = 0;
            for (int x = 0; x < b; x++)
            {
                c = c + a;
            }
            Console.WriteLine($"Task 2: a * b = {c}");
        }
        static void Task3(int a, int b)
        {
            //Даны натуральные числа а и b. Найдите частное и остаток от деления не используя операции div(/) и mod(%)
            int c = 0;
            while (a > b)
            {
                a = a - b;
                c++;
            }
            Console.WriteLine($"Task 3 - частное: {c}, остаток: {a}");
        }
        static void Task4(int a, int b)
        {
            //Даны два натуральных числа a и b, не равные нулю одновременно. Вычислите Наибольший Общий Делитель(НОД) a и b.
            if (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                    Task4(a, b);
                }
                else
                {
                    b = b % a;
                    Task4(a, b);
                }
            }
            else
            {
                Console.WriteLine(a + b);
            }

        }
        static void Task5(int a)
        {
            //Составьте программу, печатающую все простые числа от 0 до заданного натурального n
            for (int i = 0; i <= a; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Task6(int a)
        {
            //Дано натуральное число a > 1.Определить длину периода десятичной записи дроби 1 / a
            decimal m = Convert.ToDecimal(a);
            decimal n = 1 / m;
            string str = n.ToString();
            Console.WriteLine(str);
            Console.WriteLine(str.Length - 2);
        }
        static void Task7(int a)
        {
            //разложение на простые множители заданного натурального числа n > 0
            int tmp = a;
            for (int i = 2; i < a; i++)
            {
                if (tmp % i == 0)
                {
                    tmp = tmp / i;
                    Console.WriteLine(i);
                    i--;
                }
            }
        }
        static void Task10(int[] mas)
        {
            //Найти минимальное, максимальное и среднее значение в массиве целых чисел
            Console.WriteLine(mas.Min()); //min
            Console.WriteLine(mas.Max()); //max
            int s = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                s = s + mas[i];
            }
            Console.WriteLine(s / mas.Length); //middle
        }
    }
}
