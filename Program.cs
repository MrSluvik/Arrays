//Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря.
using System;
using System.Text;
using static System.Console;//щоб не писати консоле кожен раз

namespace Arrays{
    
    class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.Unicode;//для кирилиці

            Write("Введіть текст :   ");
            string text = ReadLine();
            Write("\nВведіть ключ зсуву букв: ");
            int sKey = Convert.ToInt32(ReadLine());
            string encText = CodeEncode(text, sKey);
            Write($"\nЗашифрований текст : {encText}\n");
            sKey= sKey * (-1);
            Write($"Розшифрований текст : { CodeEncode(encText, sKey)}\n\n");            

        }
        public static string CodeEncode(string text, int k)
        {
            string ABC = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯабвгґдеєжзиіїйклмнопрстуфхцчшщьюя";
            
            int size = ABC.Length;
            string edstring = "";
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                int index = ABC.IndexOf(c);
                if (index < 0) //спрацьовує якщо немає такого символу в алфавіті і залишиє його не змінним 
                {
                   
                    edstring += c.ToString();
                }
                else
                {
                    int IndexLetter = (size + index + k) % size;//формула для пошуку індексу букви для шифру
                    edstring += ABC[IndexLetter];
                }
            }
            return edstring;
        }
    }
}