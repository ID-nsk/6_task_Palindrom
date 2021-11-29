using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_task_palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа определяет является ли фраза палиндромом.");
            Console.WriteLine("Введиите фразу, которую вы хотите проверить:");
            string originalString = Console.ReadLine(); // Вводим строку
            Console.Write("Ваша фраза: " + originalString);
            originalString = originalString.ToLower();
            originalString = originalString.Replace(" ", ""); //Удаляем пробелы
            string reverseString = "";
            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                reverseString += originalString[i]; // Переворачиваем строку
            }
            if (originalString == reverseString)
                Console.WriteLine(" - является палиндромом.");
            else
                Console.WriteLine(" - не является палиндромом.");
            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
