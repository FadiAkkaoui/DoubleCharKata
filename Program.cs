using System;

namespace codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input value
            string s = "abcd";
            //Sends s value to method and returns double of each shar character
            Console.WriteLine(DoubleChar(s));
        }

        public static string DoubleChar(string s)
        {
            //Splits string calue to char character and stores it in each index
            char[] charList = s.ToCharArray();
            string result = "";
            //foreach character in the list, doubles it and stores it in result
            foreach (char x in charList)
            {
                string str = new string(x, 2);
                result += str;
            }
            return result;
        }
    }
}
