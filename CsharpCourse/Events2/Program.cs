using System;

/*
 * Создайте класс OrderEventArgs, унаследуйте его от класса EventArgs (базового класса для определения классов-аргументов событий).
 * В теле класса создайте строковое автосвойство Order.Создайте 2 класса – Owner и NotOwner.
 * В теле каждого из этих классов создайте:
 *      Событие типа EventHandler, закрытого OrderEventArgs и с именем OrderToDog.
 *      Создайте метод GiveAnOrder, который принимает строку, создаёт экземпляр OrderEventArgs, 
 *      помещает в него строку-аргумент метода и вызывает метод Invoke на событии. 
 * Создайте класс Dog. В теле класса создайте: 
 *      Строковое автосвойство Order;
 *      Метод OrderHandler – метод обработчик события, принимающий два параметра
 *          типа object (с именем sender) и типа OrderEventArgs (с именем e).
 * Если источник события – экземпляр класса Owner:
 * 1.	Выведите на экран строковое значение команды, полученное из OrderEventArgs ("Я выполняю команду  {e.Order}") .
 * 2.	Присвойте свойству Order строковое значение команды. Если источник события не Owner – выведите на экран строку «Подозрительно смотрю на постороннего».
 * В теле метода Main создайте экземпляр класса Dog. Создайте экземпляры классов Owner и NotOwner 
 * и подпишите на события этих классов метод OrderHandler.
 * Вызовите события экземпляров Owner и NotOwner.
 * Выведите на экран значение свойства Order экземпляра Dog.

 */

namespace Events2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Owner owner = new Owner();
            NotOwner notOwner = new NotOwner();

            owner.OrderToDog += dog.OrderHandler;
            notOwner.OrderToDog += dog.OrderHandler;

            owner.GiveAnOrder("Fass");
            notOwner.GiveAnOrder("Foo");

            Console.WriteLine($"Dog is doing => {dog.Order}");
        }
    }

    public class OrderEventArgs : EventArgs
    {
        public string Order { get; set; }

        public OrderEventArgs()
        {

        }

        public OrderEventArgs(string order)
        {
            Order = order;
        }

    }

    public class Owner
    {
        private event EventHandler<OrderEventArgs> orderToDog = null;

        public event EventHandler<OrderEventArgs> OrderToDog
        {
            add { orderToDog += value; }
            remove { orderToDog -= value; }
        }

        public void GiveAnOrder(string someText)
        {
            OrderEventArgs order = new OrderEventArgs(someText);
            orderToDog(this, order);
        }
    }

    public class NotOwner
    {
        private event EventHandler<OrderEventArgs> orderToDog = null;

        public event EventHandler<OrderEventArgs> OrderToDog
        {
            add { orderToDog += value; }
            remove { orderToDog -= value; }
        }

        public void GiveAnOrder(string someText)
        {
            OrderEventArgs order = new OrderEventArgs(someText);
            orderToDog(this, order);
        }
    }

    public class Dog
    {
        public string Order { get; set; }


        public void OrderHandler(object sender, OrderEventArgs e)
        {
            if(sender is Owner)
            {
                var orderOwner = sender as Owner;
                Console.WriteLine($"Я выполняю команду  {e.Order}");
                Order = e.Order;
            }

            if(sender is NotOwner)
            {
                Console.WriteLine("Подозрительно смотрю на постороннего");
            }
        }
    }
}
