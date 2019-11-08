using System;

namespace Task8_002
{
    public enum Trast
    {
        one,
        two,
        three
    }

    class Program
    {
        

        static void Main(string[] args)
        {
            var tr = new int[] { 1, 2 };
            string task = ((Trast)tr.Length).ToString();
            Console.WriteLine(task);
        }
    }
}
