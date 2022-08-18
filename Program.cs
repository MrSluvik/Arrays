//Создайте приложение, которое производит операции над матрицами:■■Умножение матрицы на число; ■■Сложение матриц; ■■Произведение матриц.
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
            WriteLine("Виберіть функцію якою хочете скористатися :\n1-Елементи матриці помножити на введене число \n2-Сума елементів матриці\n3-Добуток елементів масиву");
            int c = Convert.ToInt32(ReadLine());
            switch (c)
            {
                case 1: MultMatrixNumb(B); break;
                case 2: Write($"Сума елементів матриці :{MatrixSum(B)}"); break;
                case 3: Write($"Добуток елементів масиву :{MultMatrix(B)}"); break;
                default:
                    Write("Ви ввели не коректну дію ,ПОМИЛКА!  ");
                    break;
            }
            WriteLine("\n\n");

        }
        public static void MultMatrixNumb(double[,] matrix)
        {
            double[,] A = new double[5, 5];

            WriteLine("Введіть значення на яке помножити матрицю :");
            int n = Convert.ToInt32(ReadLine());
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    A[i, j] = matrix[i, j] * n;//новий масив заповнений числами першоъ матрицына число введене користувачем
                }
            }
            Write($"Маасив помножений на число :\t\n");
            for (int i = 0; i < 5; i++)//вивід двовимірного масиву
            {
                for (int j = 0; j < 5; j++)
                {
                    Write($"{ A[i, j]}\t");
                }
                WriteLine();
            }
        }
        public static double MatrixSum(double[,] matrix)
        {
            double sum1 = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sum1 += matrix[i, j];//сума елементів матриці
                }
            }
            return sum1;
        }
        public static double MultMatrix(double[,] matrix)
        {
            double product = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    product *= matrix[i, j];//добуток елементів матриці
                }
            }
            return product;
        }
    }
}