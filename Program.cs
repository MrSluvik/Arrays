//Создайте приложение, проверяющее текст на недопустимые слова. Если недопустимое слово найдено, оно
//должно быть заменено на набор символов *. По итогам работы приложения необходимо показать статистику действий.
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

            WriteLine("Введіть текст англійською ");

            string numb = Convert.ToString(ReadLine());
            string[] substrings = numb.Split(" ");

            WriteLine("Введіть недопустиме слово з великої а потім з малої літери \nПриклад : Die die");
            string word = Convert.ToString(ReadLine());
            string[] subword = word.Split(" ");
            int count = 0;
            string[] forbword = new string[word.Length];

            for (int i = 0; i < subword[0].Length; i++)
            {
                forbword[i] = "*";
            }
            string a = "";
            for (int i = 0; i < word.Length; i++)
            {
                a += forbword[i];

            }
           

            for (int i = 0; i < substrings.Length; i++)
            {
                if (substrings[i] == subword[0] || substrings[i] == subword[1])
                {
                    substrings[i] = a;
                    count++;
                }
            }
            for (int i = 0; i < substrings.Length; i++)
            {
                Write($"{substrings[i]} ");
            }
            Write($"Статистика : {count} заміни  забороненого слова ");

        }
    }
}
