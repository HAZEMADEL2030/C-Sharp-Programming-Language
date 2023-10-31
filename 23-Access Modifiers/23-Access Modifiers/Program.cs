using System;

namespace _23_Access_Modifiers
{

    class Person
    {
        //Access Modifiers
        private string name;
        public string address;
        //static
        public static int age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            //p.name = "Hazem";  You cannot access a private member without a property
            p.address = "Alexandria";
            //using static
            Person.age = 30;

            //Console.WriteLine(p.name);
            Console.WriteLine(p.address);
            Console.WriteLine(Person.age);
        }
    }
}