namespace _12_Enumerators
{
    internal class Program
    {

        enum Marital_Status
        {
            married,
            single
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Are you married ?");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "yes":
                    Console.WriteLine("You are: " + Marital_Status.married);
                    break;
                case "no":
                    Console.WriteLine("You are: " + Marital_Status.single);
                    break;
            }

            Console.ReadKey();
        }
    }
}