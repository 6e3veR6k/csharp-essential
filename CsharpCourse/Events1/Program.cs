﻿using System;

namespace Events1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class B
    {
        void Print()
        {
            Console.WriteLine(nameof(Print)); 
        }
    }
}
