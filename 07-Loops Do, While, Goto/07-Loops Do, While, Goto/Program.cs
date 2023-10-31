namespace _07_Loops_Do__While__Goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Do...While
            int number = 0;
            do
            {
                Console.WriteLine("Welcome");
                number++;

            } while (number > 0 && number < 5);

        //While
        Label: Console.WriteLine("Who is the first man who landed on the Moon ?");
            string khalifa = Console.ReadLine();
            while (khalifa != "Armstrong")
            {
                Console.WriteLine("False");
                goto Label;
            }
            Console.WriteLine("True");
            Console.ReadKey();
        }
    }
}