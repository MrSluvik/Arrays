//Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.Определить сумму элементов массива, расположенных
//между минимальным и максимальным элементами.

using System;
using System.Text;
using static System.Console;//щоб не писати консоле кожен раз

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.Unicode;//для кирилиці
            Random random = new Random();
            double[,] B = new double[5, 5];

            WriteLine("Введіть значення масиву А :");

            for (int i = 0; i < 5; i++)//інііалізація двовимірного масиву
            {
                for (int j = 0; j < 5; j++)
                {
                    B[i, j] = random.Next(-100, 100);

                }
            }

            for (int i = 0; i < 5; i++)//вивід двовимірного масиву
            {
                for (int j = 0; j < 5; j++)
                {
                    Write($"{ B[i, j]}\t");
                }
                WriteLine();
            }

            WriteLine("\n\n");

            int indexMaxX = 0;
            int indexMaxY = 0;

            int indexMinX = 0;
            int indexMinY = 0;

            double maxValue = B[0, 0];

            for (int i = 0; i < 5; i++)//пошук найбільшого значення 
            {
                for (int j = 0; j < 5; j++)
                {
                    if (B[i, j] > maxValue)
                    {
                        maxValue = B[i, j];
                        indexMaxY = i;
                        indexMaxX = j;

                    }
                }
            }
            Write($"Максимальне число в масиві { maxValue}\n\n");
            Write($"індекс максимального по x {indexMaxX + 1  }\n");
            Write($"індекс максимального по y { indexMaxY + 1 }\n\n");

            double minValue = B[0, 0];

            for (int i = 0; i < 5; i++)//пошук найменше значення 
            {
                for (int j = 0; j < 5; j++)
                {
                    if (B[i, j] < minValue)
                    {
                        minValue = B[i, j];
                        indexMinY = i;
                        indexMinX = j;

                    }
                }
            }
            Write($"Мінімальне число в масиві { minValue}\n\n");
            Write($"індекс мінімального по x {indexMinX + 1 }\n");
            Write($"індекс мінімального по y { indexMinY + 1}\n\n");


            bool count = false;
            double sum = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    if ((i == indexMaxY && j == indexMaxX) || (i == indexMinY && j == indexMinX))
                    {
                        if (count)
                        {
                            count = false;
                            continue;
                        }
                        else
                        {
                            count = true;
                            continue;
                        }
                    }
                    if (count)
                    {
                        sum += B[i, j];
                    }
                }

            }
            Console.WriteLine("Сума елементів масива , між мінмальним і максимальним елементом  = " + sum);

        }
    }
}