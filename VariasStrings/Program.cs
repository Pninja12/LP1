using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string entre_aspas = "\"Esta string esta ' entre aspas sem o verbatim\"";
            string entre_aspas_verbatim = @"""Esta string esta ' entre aspas com o verbatim""";
            string unicode = "\u0041";
            string unicode_verbatim = @"\u0041";
            string o = "\u004F";
            string l = "\u004C";
            string a_acentuado = "\u00C1";
            string virgula = "\u002C";
            string t = "\u0054";
            string u = "\u0055";
            string d = "\u0044";
            string b = "\u0042";
            string e = "\u0045";
            string m = "\u004D";

            Console.WriteLine("Hello, World!");
            Console.WriteLine(entre_aspas);
            Console.WriteLine(entre_aspas_verbatim);
            Console.WriteLine("A letra \"{0}\" escreve-se {1} em unicode", unicode, unicode_verbatim);
            Console.WriteLine(o + l + a_acentuado + virgula + " " + t + u + d + o + " " + b + e + m + "? Este texto é todo feito em Unicode.");
        }
    }
}
