using System;

namespace _32_Delegations
{
    class string_manipulation
    {
        public static string TextCase(string Text)
        {
            if (Text == Text.ToUpper())
            {
                return "Your Text is Capital";
            }
            else if (Text == Text.ToLower())
            {
                return "Your text is Small";
            }
            else
            {
                return "Your Text is Mixed";
            }
        }


        public string TextLength(string Text)
        {
            return string.Format("Your Text Length is: {0}", Text.Length);
        }
    }
    internal class Program
    {
        public delegate string myDelegate(string Text);
        static void Main(string[] args)
        {
            string_manipulation sm = new string_manipulation();
            myDelegate firstDelegate = new myDelegate(sm.TextLength);
            myDelegate secondDelegate = string_manipulation.TextCase;

            Console.WriteLine("Enter a string value:");
            string text = Console.ReadLine();

            Console.WriteLine(firstDelegate.Invoke(text));
            Console.WriteLine(secondDelegate(text));

            Console.Read();
        }
    }
}