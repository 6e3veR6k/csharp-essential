using System;

/*
 * Создайте структуру Point. В теле структуры создайте два private поля типа int – x и y.
 * Создайте пользовательский конструктор для инициализации полей при создании. 
 * Создайте свойства для доступа к полям.
 * Создайте класс Figure с private полем типа массива элементов Point на 6 элементов 
 * и строковым private полем figureName для указания типа фигуры, в зависимости 
 * от количества вершин фигуры (dot, line, triangle, quadrangle, pentagon, hexagon). 
 * Создайте индексатор. Значение figureName должно меняться при добавлении и удалении
 * элементов массива в соответствии с названием фигуры с таким количество точек.
 * Решите задачу, используя nullable значения элементов массива.
 * Продемонстрируйте работу функционала Figure в методе Main.
 */

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    struct Point
    {
        private int x;
        private int y;

        public int X { get => x; }
        public int Y { get => y; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Figure
    {
        private Point[] points = new Point[]
        {
            new Point(0, 0),
            new Point(1, 1),
            new Point(2, 1),
            new Point(4, 2),
            new Point(3, 3),
            new Point(1, 3)
        };

        private string figureName;
}
