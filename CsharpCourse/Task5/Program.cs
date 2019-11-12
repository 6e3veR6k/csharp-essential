using System;

/*
 * Создайте интерфейсы IInt, IInt<Y> и IInt3<DateTime>.
 * В теле интерфейса IInt создайте метод без возвращаемого значения и с сигнатурой ShowCurentData().
 * В теле интерфейса IInt<Y> создайте 2 абстрактных автосвойства типа Y и абстрактный метод SetPropsData(Y a, Y b). 
 * В теле интерфейса IInt3<DateTime> создайте абстрактное автосвойство типа DateTime пропишите метод SetCurentDateTime(). 
 * Создайте параметризированный класс Class1 реализующий все интерфейсы и с параметром, ограниченным только ссылочными типами. 
 * Продемонстрируйте работу методов на экземпляре класса Class1.
*/

namespace Geneics5
{
    class Program
    {
        static void Main(string[] args)
        {
            IInt tr = new Class1<string>();
            tr.ShowCurentData();


            IInt<string> trS = tr as IInt<string>;
            trS.SetPropsData("First argument", "Second argument");
            Console.WriteLine(trS.First);
            Console.WriteLine(trS.Second);
        }
    }


    public interface IInt 
    { 
        void ShowCurentData(); 
    }


    public interface IInt<Y> 
    {
        Y First { get; set; }
        Y Second { get; set; }

        void SetPropsData(Y a, Y b);
    }

    public interface IInt2<DateTime> 
    {
        DateTime Date { get; set; }
        void SetCurentDateTime();
    }

    public class Class1<Y> : IInt, IInt<Y>, IInt2<DateTime> where Y : class
    {
        private Y first = default(Y);
        private Y second = default(Y);
        public Y First { get => first; set => first = value; }
        public Y Second { get => second; set => second = value; }


        private DateTime date = DateTime.MinValue;

        public DateTime Date { get => date; set => date = value; }




        public void SetCurentDateTime()
        {
            date = DateTime.Now;
        }

        public void SetPropsData(Y a, Y b)
        {
            First = a;
            Second = b;
        }

        public void ShowCurentData()
        {
            Console.WriteLine($"CurentData => First: {First?.ToString()}, Second: {Second?.ToString()}");
        }
    }

}
