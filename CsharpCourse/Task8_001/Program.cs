using System;

namespace Task8_001
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "zxy";
            char[] temp = str.ToCharArray();
            Array.Reverse(temp);
            //String.Join("", temp);
            //Console.WriteLine(temp);
            //return new String(temp);
        }
    }
}
