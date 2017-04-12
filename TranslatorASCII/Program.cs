using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var fileStream = new FileStream(@"c:\file.txt", FileMode.Open, FileAccess.Read))
            //{
            //    // read from file
            //}
            string a = "sd4+vv/-4=222.4=3,4";
            Console.WriteLine("Podaj ciag znakow: ");
            string own = "";

            
            //now we have t1.Result and t2.Result

            own = Console.ReadLine();
            Aschynchro.RunAllAsync(own);

            ASCIIGetter.cutt(own);
           // ASCIIGetter.CutDobuleAnddot(own);


            System.Console.WriteLine("Press any key to see operators in text.");
            System.Console.ReadKey();
            ASCIIGetter.FindOperators(own);
            
            Console.ReadKey();


        }
    }
}