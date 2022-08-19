//Пользователь с клавиатуры вводит некоторый текст.Приложение должно изменять регистр первой буквы каждого предложения на букву в верхнем регистре.
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

            WriteLine("Введіть текст");
            string text = Convert.ToString(ReadLine());

           StringBuilder edText = new StringBuilder(text);
            
            edText[0] = Char.ToUpper(edText[0]);//відразу змінію регістр першої букви тексту  бо в цикл немає сенсу  заносити цю операцію 
            int size = edText.Length;          
            size--;
            for (int i = 1; i < edText.Length; i++)
            {
                if (i == size)//коли дійшли до кінця і там стоїть крапка
                {
                    break;
                }
               else  if (edText[i] == '.' && edText[i+1]==' ' ) //варіант такий : я Земля. Ти людина.
                {
                edText[i+2]= Char.ToUpper(edText[i+2]);
                    
                }
               else if (edText[i] == '.' && edText[i + 1] != ' ' ) //я Земля.Ти людина.
                {
                    edText[i + 1] = Char.ToUpper(edText[i + 1]);

                }

            }
            edText.ToString();
            Write($"{edText}");
        }
    }
}