using System;


/*
 * Создайте класс  Human. Создайте делегат, который может быть проассоциирован с методом, 
 * который ничего не возвращает и не принимает. В теле класса создайте событие JumpE, в соответствии с делегатом. 
 * Создайте защищенный механизм доступа к событию для добавления и удаления методов-обработчиков. 
 * Создайте метод Jump, выводящий на экран слово «прыгаю».
 * Создайте экземпляр Human в методе Main, подпишите метод Jump на событие JumpE.
 * Вызовите возникновение события JumpE.
 * 
 */


namespace Events1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            human.JumpE += human.Jump;

            human.StartGame();
        }
    }

    public delegate void DefaultDelegate();

    public class Human
    {
        private event DefaultDelegate jumpE = null;

        public event DefaultDelegate JumpE
        {
            add { jumpE += value; }
            remove { jumpE -= value; }
        }

        public void Jump()
        {
            Console.WriteLine("Jumping...");
        }

        public void StartGame()
        {
            Console.WriteLine("Game start!");
            jumpE();
        }
    }
}
