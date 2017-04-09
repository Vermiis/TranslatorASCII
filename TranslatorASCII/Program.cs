using System;
using System.Text;

namespace TranslatorASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "sd4+vv/-4=222.4=3,4";
            Console.WriteLine("Podaj ciag znakow: ");
            string own = "";
            own=Console.ReadLine();
            ASCIIGetter.cutt(own);
            ASCIIGetter.FindOperators(own);
            Console.ReadKey();


        }
    }
}