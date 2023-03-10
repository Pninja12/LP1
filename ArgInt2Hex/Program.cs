using System;

namespace ArgInt2Hex
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int NumberVerify;

            bool NumberVerified= int.TryParse(str, out NumberVerify);
            Console.WriteLine(NumberVerify == 0 ? $"{str} -> Não é inteiro" : $"{str} -> É inteiro, valor hexadecimal {NumberVerify,0:x1}");
            NumberVerified= int.TryParse(str1, out NumberVerify);
            Console.WriteLine(NumberVerify == 0 ? $"{str1} -> Não é inteiro" : $"{str1} -> É inteiro, valor hexadecimal {NumberVerify,0:x1}");
            NumberVerified= int.TryParse(str2, out NumberVerify);
            Console.WriteLine(NumberVerify == 0 ? $"{str2} -> Não é inteiro" : $"{str2} -> É inteiro, valor hexadecimal {NumberVerify,0:x1}");

            //creditos : https://www.arungudelli.com/pt-pt/tutorial/c-sharp/check-if-string-is-number/
        }
    }
}
