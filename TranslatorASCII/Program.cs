using System;
using System.Text;

namespace TranslatorASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz ciag znakow");
            var x = Console.ReadLine();
            // string value = "9quali52ty3+-/*";

            var y =ASCIIGetter.codes(x);
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            //ASCIIGetter.Comparator(y);

        }
    }
}