//Объявить одномерный(5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. Заполнить одномерный массив
//А числами, введенными с клавиатуры пользователем, а двумерный массив В случайными числами с помощью циклов. Вывести на экран значения массивов: массива
//А в одну строку, массива В — в виде матрицы. Найти вданных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее
//произведение всех элементов, сумму четных элементов массива А, сумму нечетных столбцов массива В.

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

            int size = 5;
            double[] A = new double[size];
            double[,] B = new double[3, 4];

            WriteLine("Введіть значення масиву А :");

            for (int i = 0; i < A.Length; i++) //заповнення одновимірного масиву
            {
                A[i] = Convert.ToDouble(ReadLine());

            }

            for (int i = 0; i < 3; i++)//заповнення двовимірного масиву
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = random.Next(-10, 11) / 100.0;

                }
            }

            WriteLine("\n\n");

            foreach (var item in A)//вивід одновимірного масиву
            {
                Write($"{item}\t");

            }

            WriteLine("\n\n");

            for (int i = 0; i < 3; i++)//вивід двовимірного масиву
            {
                for (int j = 0; j < 4; j++)
                {
                    Write($"{ B[i, j]}\t");
                }
                WriteLine();
            }

            int c = 0;
            for (int i = 0; i < 5; i++)//знаходимо кількість спільних елементів
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (A[i] == B[j, k])
                        {
                            c++;
                        }
                    }
                }
            }
            if (c > 0) //спрацьовує якщо є спільні елементи
            {
                double[] F = new double[c];//масив для спільних елементів 
                int s = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 4; k++)
                        {

                            if (A[i] == B[j, k])
                            {
                                F[s] = A[i]; //заповнення масиву
                                s++;
                            }
                        }
                    }
                }

                double maxValue = F[0];
                for (int i = 0; i < c; i++)//пошук найбільшого значення серед спільних чисел
                {
                    if (F[i] > maxValue)
                    {
                        maxValue = F[i];
                    }
                }
                WriteLine($"\nСпільний максимальний елемент : {maxValue}");

                double minValue = F[0];
                for (int i = 0; i < c; i++)//пошук найменшого значення серед спільних чисел
                {
                    if (F[i] < minValue)
                    {
                        minValue = F[i];
                    }
                }
                WriteLine($"\nСпільний мінімальний елемент :{minValue}");
            }

            double allsum = 0;
            double sum = 0;
            double sum1 = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += A[i];        //сума ел. першого масиву     

            }

            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    sum1 += B[j, k];//сума елементів другого масиву
                }
            }

            allsum = sum + sum1;//загальна сума
            WriteLine($"\nСпільна сума елементів :{allsum}");

            double allproduct = 0;
            double product = 1;
            double product1 = 1;
            for (int i = 0; i < 5; i++)
            {
                product *= A[i];//добуток чисел першого масиву                 
            }

            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    product1 *= B[j, k];//добуток чисел другого масиву
                }
            }
            allproduct = product * product1;//загальний добуток
            WriteLine($"\nСпільний добуток елементів :{allproduct}");

            double sumtwo = 0;
            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    sumtwo += A[i];        //сума парних ел. першого масиву                
                }
            }
            WriteLine($"\nСума парних елементів першого масиву :{sumtwo}");

            double sumtwo2 = 0;
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (k % 2 != 0)
                    {
                        sumtwo2 += B[j, k]; //сума чисел у непарх стовпцях
                    }
                }
            }
            WriteLine($"\nСума чисел у непарх стовпцях масиву:{  sumtwo2}");
            //P.S нуль вважається парним
        }
    }
}
