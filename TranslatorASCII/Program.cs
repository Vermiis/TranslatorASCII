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
            string own = "2,2,2";
            //ASCIIGetter.CutDobuleAnddot(own);


            own=Console.ReadLine();
            ASCIIGetter.cutt(own);
            ASCIIGetter.CutDobuleAnddot(own);


            System.Console.WriteLine("Press any key to see operators in text.");
            System.Console.ReadKey();
            ASCIIGetter.FindOperators(own);
            
            Console.ReadKey();


        }
    }
}