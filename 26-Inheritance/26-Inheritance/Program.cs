namespace _26_Inheritance
{
    //Main Class
    class Person
    {
        //Fields
        private string Name;
        private int Age;
        private string Address;

        //Method
        public void PrintMessage()
        {
            Console.WriteLine("I am a person");
        }
    }

    class Doctor : Person
    {
        private string Speciality;
    }

    class Programmer : Person
    {
        private string Programming_Language;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer prg = new Programmer();
            prg.PrintMessage();
            Console.ReadKey();
        }
    }
}