using System;
using System.Collections.Generic;
using System.Linq;
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

        public static void Comparator (string CurrentString)
        {
            //int value = (int)CurrentString[i];
            foreach (var item in CurrentString)
            {
                
                if (item>=65 && item<=90)
                {
                    Console.WriteLine("Capital letter identyficator");
                }
                else if (item >= 97 && item <= 122)
                {
                    Console.WriteLine("Small letter identyficator");
                }
                else
                {
                    IntOrDouble(item.ToString());
                }

                
            }
        }
        public static void cutt(string text)
        {
            char[] delimiterChars = { '+', '-', '=', '*', '/' };

            //string text = "9A+4-g=9";
            System.Console.WriteLine("Original text: '{0}'", text);

            string[] words = text.Split(delimiterChars);
            System.Console.WriteLine("{0} words in text:", words.Length);

            foreach (string s in words)
            {
                System.Console.WriteLine(s);
                if (cutForDouble(s)==true)
                {
                    IntOrDouble(s);
                }
                else
                {
                    Console.WriteLine("Item contais one or more letters, it's ident then");
                }
                
            }

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
        public static void IntOrDouble(string text)
        {
            if ((text.Contains(".") || text.Contains(","))&&cutForDouble(text)==true&&(text.Length)>0)
            {
                
                Console.WriteLine("Double");
            }
            else if ((!text.Contains(".") || !text.Contains(",")))
            {
                Console.WriteLine("Integer");
            }
            else
            {
                Console.WriteLine("X");
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
            }
           
        }
        public static bool cutForDouble(string text)
        {
            char[] delimiterChars = { '.', ',' };          
            string[] words = text.Split(delimiterChars);
            bool CorrectDouble = false;
            foreach (var item in words)
            {
                if (IsDigit(item)==true)
                {
                    CorrectDouble = true;
                }
               
            }
            return CorrectDouble;
        }

        public static bool IsDigit(string text)
        {

            bool allDigits = text.All(char.IsDigit);
            if (text.All(char.IsDigit) )
            {

            }
           
            return allDigits;
        }




    }




}
