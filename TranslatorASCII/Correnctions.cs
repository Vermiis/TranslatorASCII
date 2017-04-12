using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TranslatorASCII
{
    class Correnctions
    {
        public static bool IsDigit(string text)
        {

            bool allDigits = text.All(char.IsDigit);


            return allDigits;
        }
        public static bool IsIdent(string text)
        {
            bool isLetter = !String.IsNullOrEmpty(text) && Char.IsLetter(text[0]);
            if (isLetter == true)
            {
                return true;
            }
            else
                return false;
        }
        public static bool IsCorrectDouble(string text)
        {
            char[] delimiterChars = { '.', ',' };
            string[] words = text.Split(delimiterChars);
            //if (text.Count().Select(delimiterChars))
            bool CorrectDouble = false;
            //kontrola czy zawiera wiecej niz jeden , lub .
            var x = text.Count(c => c == '.');
            var y = text.Count(c => c == ',');
            //if (((y >= 2) || x >= 2) || text.Contains('.') && text.Contains(','))
            //{
            //    int idx = text.LastIndexOf('.');
            //    Console.WriteLine(text.Substring(0, idx));
            //    Console.WriteLine(text.Substring(idx + 1));
            //}
            //if ((((y >= 2) || x >= 2) || text.Contains('.') && text.Contains(',')))
            //{
            //    return false;

            //}


            foreach (var item in words)
            {
                if (IsDigit(item) == true)
                {
                    CorrectDouble = true;
                }
                else
                {
                    CorrectDouble = false;
                }

            }
            return CorrectDouble;
        }
        public static bool IntOrDouble(string text)
        {
            if ((text.Contains(".") || text.Contains(",")) && ASCIIGetter.cutForDouble(text) == true && (text.Length) > 0)
            {

                Console.WriteLine("Double");
                return true;
            }
            else if ((!text.Contains(".") || !text.Contains(",")) && (text.Length) > 0 && IsDigit(text))
            {
                Console.WriteLine("Integer");
                return false;
            }
            else
                return false;
           

        }
    }
}
