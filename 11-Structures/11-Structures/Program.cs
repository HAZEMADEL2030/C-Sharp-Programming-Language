using System;

namespace _11_Structures
{
    internal class Program
    {

        struct Person
        {
            public string FullName;
            public int Age;

        }
        static void Main(string[] args)
        {
            Person P = new Person();
            Console.WriteLine("Enter your Name:");
            P.FullName = Console.ReadLine();

            Console.WriteLine("Enter your Age:");
            P.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your Full Name is: " + P.FullName + ", and your Age is: " + P.Age);
            Console.ReadKey();
        }
    }
}