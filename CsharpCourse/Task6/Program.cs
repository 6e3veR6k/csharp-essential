using System;
using System.Collections.Generic;

/*
 * Создайте словарь типа Dictionary, закрытый двумя строками.
 * Напишите программу, в которой пользователь вводит по 3 слова 
 * в переводе на русском и английском языках и тем самым заполняет словарь типа Dictionary.
 * Создайте метод, принимающий коллекцию нашего типа и запрашивающий 
 * пользователя ввести слово на том языке, на котором внесены ключи чтобы проверить есть ли такое значение. 
*/


namespace Task6
{
    class Program
    {
        public static Dictionary<string, string> dictionary = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Console.Write("Enter new word in english: ");
            string wordInEnglish = Console.ReadLine();
            Console.Write($"Enter russian translate for {wordInEnglish}: ");
            string wordInRussian = Console.ReadLine();
        }
    }
}
