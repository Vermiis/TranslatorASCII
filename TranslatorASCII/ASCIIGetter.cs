using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TranslatorASCII
{
    class ASCIIGetter
    {
        
        public static void cutt(string text)
        {
            char[] delimiterChars = { '+', '-', '=', '*', '/', '(', ')', '{', '}', '|', ' ', '[', ']' };

            //string text = "9A+4-g=9";
            System.Console.WriteLine("Original text: '{0}'", text);

            string[] words = text.Split(delimiterChars);
            System.Console.WriteLine("{0} words in text:", words.Length);

            foreach (string s in words)
            {
                System.Console.WriteLine(s);
                if (cutForDouble(s) == true)
                {
                    IntOrDouble(s);
                }
                else if ((s.Contains(".") || s.Contains(",")) && cutForDouble(text) == false && (text.Length) > 0)
                {
                    Console.WriteLine("Syntax ERROR");
                }
                else if (IsIdent(text) == true && (text.Length) > 0)
                {
                    Console.WriteLine("IDENT");
                }
                else if (cutForDouble(text)==false)
                {
                    CutDobuleAnddot(text);
                }
               


            }


            
        }
        public static void IntOrDouble(string text)
        {
            if ((text.Contains(".") || text.Contains(",")) && cutForDouble(text) == true && (text.Length) > 0)
            {

                Console.WriteLine("Double");
            }
            else if ((!text.Contains(".") || !text.Contains(",")) && (text.Length) > 0 && IsDigit(text))
            {
                Console.WriteLine("Integer");
            }
            else
            {
                //  Console.WriteLine("Syntax error");
            }

        }
        public static void FindOperators(string CurrentString)
        {

            Console.WriteLine("Operators found in text:");
            for (int i = 0; i < CurrentString.Length; i++)
            {
                // Console.WriteLine(CurrentString[i] + "\t" + "Unicode code is: " + (int)CurrentString[i]);
                int value = (int)CurrentString[i];
                if (value == 40)
                {
                    Console.WriteLine(CurrentString[i] + "Opening bracket");
                }
                if (value == 41)
                {
                    Console.WriteLine(CurrentString[i] + "Closing bracket");
                }
                if (value == 42)
                {
                    Console.WriteLine(CurrentString[i] + "Multiplication operator");
                }
                if (value == 43)
                {
                    Console.WriteLine(CurrentString[i] + "Add operator");
                }

                if (value == 45)
                {
                    Console.WriteLine(CurrentString[i] + "Substration operator");
                }
                if (value == 47)
                {
                    Console.WriteLine(CurrentString[i] + "Division operator");
                }
                if (value == 61)
                {
                    Console.WriteLine(CurrentString[i] + "Equals operator");
                }
                if (value == 91)
                {
                    Console.WriteLine(CurrentString[i] + "Opening bracket");
                }
                if (value == 93)
                {
                    Console.WriteLine(CurrentString[i] + "Closing bracket");
                }
                if (value == 123)
                {
                    Console.WriteLine(CurrentString[i] + "Opening bracket");
                }
                if (value == 124)
                {
                    Console.WriteLine(CurrentString[i] + "|");
                }
                if (value == 125)
                {
                    Console.WriteLine(CurrentString[i] + "Closing bracket");
                }
            }

        }
        public static bool cutForDouble(string text)
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
            if ((((y >= 2) || x >= 2) || text.Contains('.') && text.Contains(',')))
            {
                return false;
                
            }           
            
            
            foreach (var item in words)
            {
                if (IsDigit(item)==true)
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

        public static bool IsDigit(string text)
        {

            bool allDigits = text.All(char.IsDigit);
            
           
            return allDigits;
        }
        public static bool IsIdent (string text)
        {
            bool isLetter = !String.IsNullOrEmpty(text) && Char.IsLetter(text[0]);
            if (isLetter == true)
            {
                return true;
            }
            else
                return false;
        }
        public static void CutIdentAndInt(string text)
        {
            if (IsIdent(text)==false)
            {
                //123 - int  abc-ident
                //123xyz123ab  123 int xyz123ab ident



            }
        }
        public static void CutDobuleAnddot(string text)
        {
            
            if (text.Count(c => c == '.')>=2 && OnlyBool.IsCorrectDouble(text)==true)
            {
                int lastDotIndex = text.LastIndexOf(".", System.StringComparison.Ordinal);
                string firstPart = text.Remove(lastDotIndex);
                string secondPart = text.Substring(lastDotIndex + 1, text.Length - firstPart.Length - 1);
                Console.WriteLine(firstPart +"DOUBLE");
                Console.WriteLine('.'+secondPart+" ERROR");
            }
            else if (text.Count(c => c == ',')>=2)
            {
                int lastDotIndex = text.LastIndexOf(",", System.StringComparison.Ordinal);
                string firstPart = text.Remove(lastDotIndex);
                string secondPart = text.Substring(lastDotIndex + 1, text.Length - firstPart.Length - 1);
                Console.WriteLine(firstPart + "DOUBLE");
                Console.WriteLine(','+secondPart + " ERROR");
            }
        }




    }




}
