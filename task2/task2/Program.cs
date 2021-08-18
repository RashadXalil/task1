using System;

namespace ca5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stringi daxil et  : ");
            string soz = Console.ReadLine();
            task1(soz);
        }
        static string task1(string soz)
        {

            string reverse = "";
            int length = soz.Length - 1;

            while (length >= 0)
            {
                reverse += soz[length];
                length--;
            }
            Console.WriteLine(reverse);
            return reverse;
        }
    }
}
