//Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно посчитать его результат. Необходимо поддерживать только две операции: + и –.
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

            WriteLine("Введіть матиматичний вираз\n Приклад : 2 + 3\nПідтримуються лише операція + та - ");

            string numb = Convert.ToString(ReadLine());                
            string[] substrings = numb.Split(" ");

            double a = Convert.ToInt32(substrings[0]);
            string ope = Convert.ToString(substrings[1]);
            double b = Convert.ToInt32(substrings[2]);

            double result=0 ;

            if (ope == "+") { 
                result = a + b; 
            }
            else if (ope == "-") {
                result = a - b; 
            }          
            else { 
                WriteLine("Ви ввели не коректно матиматичий вираз");
            }
            WriteLine($"Отриманий результат = {result}");
        }
    }
}
