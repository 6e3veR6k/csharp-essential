using System;

/*
 * Создайте делегат Del, параметризированный местом заполнения типом T, 
 * и сообщаемый с методом, который ничего не возвращает и принимает два аргумента типа T – оба по ссылке.
 * Создать методы, сообщаемые с Del:
 *  1.	Меняющий значения переменных местами.
 *  2.	Выводящий на экран строку: «значение первого аргумента – {0}, значение второго аргумента – {1}»;
 * Сообщите методы с экземпляром делегата del1, закрытым интом, в таком порядке: 2, 1, 2.
 * Создайте другой экземпляр делегата - del2, закрытый строкой, и сообщите с ним методы в таком же порядке.
 * Проверьте работу делегата целочисленными значениями и со строковыми значениями.
*/


namespace Task1
{
    public delegate void Del<T>(ref T first, ref T second);


    public class Program
    {
        static void Main(string[] args)
        {
            var dynamicClass = new Helper();
            Del<int> del1 = null;


            del1 += dynamicClass.PrintArguments;
            del1 += dynamicClass.Swap;
            del1 += dynamicClass.PrintArguments;

            Del<string> del2 = null;


            del2 += dynamicClass.PrintArguments;
            del2 += dynamicClass.Swap;
            del2 += dynamicClass.PrintArguments;


            int x = 10, y = 99;
            string first = "Hello ", second = "world!";


            del1(ref x, ref y);
            del2(ref first, ref second);

        }
    }

    public class Helper
    {
        public void Swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }


        public void PrintArguments<T>(ref T first, ref T second)
        {
            Console.WriteLine($"Значение первого аргумента – {first}, значение второго аргумента – {second}");
        }
    }
}
