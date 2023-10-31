namespace _27_Abstract_and_Sealed_Classes
{
    abstract class Person
    {
        public void PrintMessage()
        {
            Console.WriteLine("I am a person");
        }
    }

    class Programmer : Person
    {

    }

    sealed class Book
    {
    }

    //you cannot derive from a sealed class
    /* class ebook : Book
     {
     } */
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer prm = new Programmer();
            prm.PrintMessage();
        }
    }
}