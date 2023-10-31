namespace _29_Overriding_and_Polymorphism
{
    class Science
    {
        virtual public void Description()
        {
            Console.WriteLine("Science is the main class");
        }
    }

    class Biology : Science
    {
        new public void Description()
        {
            Console.WriteLine("Biology is a derived class");
        }
    }

    class Chemistry : Science
    {
        public override void Description()
        {
            Console.WriteLine("Chemistry is a derived class");
        }
    }

    class Physics : Science
    {
        public override void Description()
        {
            Console.WriteLine("Physics is a derived class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Biology biology = new Biology();
            Chemistry chemistry = new Chemistry();
            Physics physics = new Physics();

            Science science = new Science();
            Console.WriteLine("using <--new-->");
            science.Description();


            science = new Biology();
            science = new Chemistry();
            science = new Physics();
            Console.WriteLine("using <--override-->");
            biology.Description();

            chemistry.Description();
            physics.Description();
            Console.ReadKey();
        }
    }
}