using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 0;
            int b = 1;
            int c = 2;
            char unicode = '\u4327';
            float real = 12.4f;

            Console.WriteLine("{0}", a);
            Console.WriteLine("{0} {1}", b, c);
            Console.WriteLine(unicode);
            Console.WriteLine(real);
        }
    }
}

