using System;
using System.Collections.Generic;
using System.Text;

namespace TranslatorASCII
{
    class ASCIIGetter
    {
        public static List<int> codes(string tekst)
        {
            //string value = "9quali52ty3+-/*";
            List<int> CodesList=null;

            // Convert the string into a byte[].
            byte[] asciiBytes = Encoding.ASCII.GetBytes(tekst);
            foreach (var item in asciiBytes)
            {
                
                CodesList.Add(item);               
            }
            return CodesList;
        }

        public static void Comparator (List<int> val)
        {
            foreach (var item in val)
            {
                if (item==40)
                {
                    Console.WriteLine("Opening bracket");
                }
                if (item==41)
                {
                    Console.WriteLine("Closing bracket");
                }
                if (item==43)
                {
                    Console.WriteLine("Add operator");
                }
                if (item==44)
                {
                    Console.WriteLine("Multiplication operator");
                }
                if (item==45)
                {
                    Console.WriteLine("Substration operator");
                }
                if (item==47)
                {
                    Console.WriteLine("Division operator");
                }
                if (item>=65 && item<=90)
                {
                    Console.WriteLine("duza literka");
                }
                else if (item >= 97 && item <= 122)
                {
                    Console.WriteLine("mala literka");
                }

                
            }
        }
    }




}
