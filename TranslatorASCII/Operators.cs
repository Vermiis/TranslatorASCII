using System;
using System.Collections.Generic;
using System.Text;

namespace TranslatorASCII
{
    class Operators
    {
        public static List<string> FindOperators(string CurrentString)
        {
            List<string> operators=null;
            Console.WriteLine("Operators found in text:");
            for (int i = 0; i < CurrentString.Length; i++)
            {
                // Console.WriteLine(CurrentString[i] + "\t" + "Unicode code is: " + (int)CurrentString[i]);
                int value = (int)CurrentString[i];
                if (value == 40)
                {
                    Console.WriteLine(CurrentString[i] + "Opening bracket");
                    operators.Add(CurrentString[i] + "Opening bracket");
                }
                if (value == 41)
                {
                    operators.Add(CurrentString[i] + "Closing bracket");
                }
                if (value == 42)
                {
                    operators.Add(CurrentString[i] + "Multiplication operator");
                }
                if (value == 43)
                {
                    operators.Add(CurrentString[i] + "Add operator");
                }

                if (value == 45)
                {
                    operators.Add(CurrentString[i] + "Substration operator");
                }
                if (value == 47)
                {
                    operators.Add(CurrentString[i] + "Division operator");
                }
                if (value == 61)
                {
                    operators.Add(CurrentString[i] + "Equals operator");
                }
                if (value == 91)
                {
                    operators.Add(CurrentString[i] + "Opening bracket");
                }
                if (value == 93)
                {
                    operators.Add(CurrentString[i] + "Closing bracket");
                }
                if (value == 123)
                {
                    operators.Add(CurrentString[i] + "Opening bracket");
                }
                if (value == 124)
                {
                    operators.Add(CurrentString[i] + "|");
                }
                if (value == 125)
                {
                    operators.Add(CurrentString[i] + "Closing bracket");
                }
            }
            return operators;

        }

        public static List<string> FindWords(string text)
        {
            char[] delimiterChars = { '+', '-', '=', '*', '/', '(', ')', '{', '}', '|', ' ', '[', ']' };

            //string text = "9A+4-g=9";
            System.Console.WriteLine("Original text: '{0}'", text);

            string[] words = text.Split(delimiterChars);
            List<string> Wordz = null;
            System.Console.WriteLine("{0} words in text:", words.Length);

            foreach (string s in words)
            {
                System.Console.WriteLine(s);
                Wordz.Add(s);
                if (ASCIIGetter.cutForDouble(s) == true)
                {
                    OnlyBool.IntOrDouble(s);
                }
                else if ((s.Contains(".") || s.Contains(",")) && ASCIIGetter.cutForDouble(text) == false && (text.Length) > 0)
                {
                    // Console.WriteLine("Syntax ERROR");
                    ASCIIGetter.CutDobuleAnddot(s);
                }
                else if (OnlyBool.IsIdent(text) == true && (text.Length) > 0)
                {
                    Console.WriteLine("IDENT");
                }
                else if (ASCIIGetter.cutForDouble(text) == false)
                {
                    ASCIIGetter.CutDobuleAnddot(text);
                }



            }
            return Wordz;



        }


    }
}
