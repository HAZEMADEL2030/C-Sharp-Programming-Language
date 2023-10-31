namespace _28_Virtual_Methods
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

        virtual public void Work()
        {
            Console.WriteLine("I work as a Full Stack Developer");
        }

    }


    //Derived Class
    class Programmer : Person
    {
        public override void Work()
        {
            //Message From Main Class
            base.Work();

            //Message From Derived Class
            Console.WriteLine("I am a programmer");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer prm = new Programmer();
            prm.Work();
            Console.Read();
        }
    }
}