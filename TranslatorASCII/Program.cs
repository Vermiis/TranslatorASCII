using System;
using System.Text;

namespace TranslatorASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "sd4+vv/-4=222.4=3,4";
            ASCIIGetter.cutt(a);
            ASCIIGetter.FindOperators(a);


        }
    }
}