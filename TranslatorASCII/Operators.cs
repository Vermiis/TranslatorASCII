using System;
using System.Collections.Generic;
using System.Text;

namespace TranslatorASCII
{
    class Operators
    {
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
    }
}
