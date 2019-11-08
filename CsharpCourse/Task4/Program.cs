using System;

//Создайте интерфейсы IInt и IInt<Y>.
//В теле интерфейса IInt пропишите метод без возвращаемого значения и с сигнатурой ShowClassType(), 

//В теле интерфейса IInt<Y> создайте абстрактное автосвойство типа Y и метод без возвращаемого значения с сигнатурой ShowPropType().

//Создайте класс Class1, реализующий интерфейс IInt, создайте класс Class2, реализующий оба интерфейса.
//Создайте экземпляры классов Class1 и Class2 в методе Main и продемонстрируйте на них работу созданных методов.


namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.ShowClassType();

            Class2<decimal> class2 = new Class2<decimal>();
            class2.ShowClassType();
            class2.ShowPropType();
        }
    }

    public interface IInt 
    {
        void ShowClassType();
    }

    public interface IInt<Y> 
    {
        abstract Y GetY { get; set; }

        void ShowPropType();
    }

    public class Class1 : IInt
    {
        public void ShowClassType()
        {

            Console.WriteLine($"Type - {typeof(Class1)}");
            Console.WriteLine($"Type - {this.GetType()}");
        }
    }

    public class Class2<Y> : IInt, IInt<Y>
    {
        private Y item;

        public Y GetY 
        { 
            get => item;
            set => item = value; 
        }

        public void ShowClassType()
        {
            Console.WriteLine($"Class2 - {this.GetType()}");
            Console.WriteLine($"Class2 - {typeof(Class2<Y>)}");
        }

        public void ShowPropType()
        {
            Console.WriteLine($"Class2 - {item.GetType()}");
        }
    }
}
