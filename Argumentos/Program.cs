﻿using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            for(int i = 0; i < args; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}
