namespace _20_Console_and_Others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console Properties
            Console.Title = "C# Lesson";
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            //Escape Characters
            Console.WriteLine("Welcome to the\tworld\nmy name is:\"Hazem\"");

            //Break and Continue
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i);
                if (i < 10) continue; break;
            }

            //display string
            string name = "Hazem";
            Console.WriteLine("My name is:{0}", name);

            Console.Read();
        }
    }
}