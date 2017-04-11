using System;
using System.IO;
using System.Text;

namespace TranslatorASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var fileStream = new FileStream(@"c:\file.txt", FileMode.Open, FileAccess.Read))
            {
                // read from file
            }
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