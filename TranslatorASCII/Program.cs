using System;
using System.Text;

namespace TranslatorASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            string CurrentString = "g+6/l-9";
            for (int i = 0; i < CurrentString.Length; i++)
            {
                Console.WriteLine(CurrentString[i] + "\t" + "Unicode code is: " + (int)CurrentString[i]);
                int value = (int)CurrentString[i];
                if (value == 40)
                {
                    Console.WriteLine("Opening bracket");
                }
                if (value == 41)
                {
                    Console.WriteLine("Closing bracket");
                }
                if (value == 43)
                {
                    Console.WriteLine("Add operator");
                }
                if (value == 44)
                {
                    Console.WriteLine("Multiplication operator");
                }
                if (value == 45)
                {
                    Console.WriteLine("Substration operator");
                }
                if (value == 47)
                {
                    Console.WriteLine("Division operator");
                }
                if (value >= 65 && value <= 90)
                {
                    Console.WriteLine("duza literka");
                }
                else if (value >= 97 && value <= 122)
                {
                    Console.WriteLine("mala literka");
                }
            }


        }
    }
}