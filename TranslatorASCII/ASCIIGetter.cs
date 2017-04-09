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
                    Console.WriteLine("Capital letter identyficator");
                }
                else if (item >= 97 && item <= 122)
                {
                    Console.WriteLine("Small letter identyficator");
                }

                
            }
        }

        static void cutt(string text)
        {
            char[] delimiterChars = { '+', '-', '=', '*', '/' };

            //string text = "9A+4-g=9";
            System.Console.WriteLine("Original text: '{0}'", text);

            string[] words = text.Split(delimiterChars);
            System.Console.WriteLine("{0} words in text:", words.Length);

            foreach (string s in words)
            {
                System.Console.WriteLine(s);
            }

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }

        public static void FindOperators(string CurrentString)
        {
           
            for (int i = 0; i < CurrentString.Length; i++)
            {
                Console.WriteLine(CurrentString[i] + "\t" + "Unicode code is: " + (int)CurrentString[i]);
                int value = (int)CurrentString[i];
                if (value == 40)
                {
                    Console.WriteLine(CurrentString[i] + "Opening bracket");
                }
                if (value == 41)
                {
                    Console.WriteLine(CurrentString[i] + "Closing bracket");
                }
                if (value == 43)
                {
                    Console.WriteLine(CurrentString[i] + "Add operator");
                }
                if (value == 44)
                {
                    Console.WriteLine(CurrentString[i] + "Multiplication operator");
                }
                if (value == 45)
                {
                    Console.WriteLine(CurrentString[i] + "Substration operator");
                }
                if (value == 47)
                {
                    Console.WriteLine(CurrentString[i] + "Division operator");
                }
            }
           
        }


    }




}
