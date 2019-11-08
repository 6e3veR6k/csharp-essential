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
            Figure figure = new Figure();

            for(int i = 0; i < 6; i++)
            {
                figure.Add(new Point(i, 6 - i));
            }

            Console.WriteLine(new string('#', 50));
            Console.WriteLine(figure.FigureName);


            Point t = figure[3];
            Console.WriteLine($"point3 has coordinates => ({t.X}, {t.Y})");

            for(int i = 0; i < figure.PointsCount; i++)
            {
                Point point = figure[i];

                Console.WriteLine($"point{i} => ({point.X}, {point.Y})");
            }


            Console.WriteLine(new string('#', 50));
            figure.Remove(4);
            Console.WriteLine(figure.FigureName);

            for (int i = 0; i < figure.PointsCount; i++)
            {
                Point point = figure[i];

                Console.WriteLine($"point{i} => ({point.X}, {point.Y})");
            }

        }
    }

    public struct Point
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

    public enum FiguresName
    {
        dot = 1, 
        line, 
        triangle, 
        quadrangle, 
        pentagon, 
        hexagon
    }

    public class Figure
    {
        private Point[] points;

        public string FigureName
        { 
            get
            {
                if (PointsCount <= (Enum.GetNames(typeof(FiguresName)).Length))
                    return Enum.GetName(typeof(FiguresName), PointsCount);
                else
                    return "Polygon";
            } 
        }
        private int count;
        private int defaultCapacity = 4;

        public int PointsCount
        {
            get => count;
        }

        private Point[] emptyArray = new Point[0];

        public Figure()
        {
            points = emptyArray;
        }

        public Figure(Point point)
        {
            points = new Point[defaultCapacity];
            points[count++] = point;
        }

        public Figure(params Point[] points)
        {
            this.points = points;
            count = this.points.Length;
        }

        private void ExtendArray()
        {
            Point[] temp;
            if (points.Length == 0)
            {
                points = new Point[defaultCapacity];
            }
            else
            {
                temp = new Point[count * defaultCapacity];
                Array.Copy(points, 0, temp, 0, points.Length - 1);
                points = temp;
            }
        }

        public void Add(Point point)
        {
            if(count == this.points.Length)
            {
                ExtendArray();
            }

            this.points[count++] = point;
        }

        public void Remove(int index)
        {
            if (index >= 0 && index < points.Length)
            {
                count--;
                Array.Copy(points, index + 1, points, index, count - index);
            }

        }

        public Point this[int index]
        {
            get
            {
                if (index >= 0 && index < points.Length)
                    return points[index];
                else
                    throw new IndexOutOfRangeException();
            }

            set
            {
                if (index >= 0 && index < points.Length)
                    points[index] = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }
    }

}
