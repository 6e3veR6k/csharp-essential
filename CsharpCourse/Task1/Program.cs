﻿using System;

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
            Console.WriteLine("Hello World!");
        }
    }
}
