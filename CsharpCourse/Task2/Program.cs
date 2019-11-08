using System;

/*
 * Напишите обобщенный класс, который может хранить в массиве объекты любого одного типа.
 * Кроме того, данный класс должен иметь механизмы для добавления данных в массив,
 * удаления из массива, получения элемента из массива по индексу и метод, возвращающий длину массива.
 * Для упрощения работы можно пересоздавать массив при каждой операции добавления и удаления.
*/

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray<int> myArray = new MyArray<int>();

            myArray.Add(1);
            myArray.Add(2);
            myArray.Add(3);
            myArray.Add(4);
            myArray.Add(5);
            myArray.Add(6);

            myArray.Remove(3);


            MyArray<string> myArray2 = new MyArray<string>();
                                   
            myArray2.Add("string - 1");
            myArray2.Add("string - 2");
            myArray2.Add("string - 3");
            myArray2.Add("string - 4");
            myArray2.Add("string - 5");
            myArray2.Add("string - 6");

            myArray2.Remove(3);
        }
    }
}
